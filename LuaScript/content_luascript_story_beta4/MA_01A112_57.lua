-- このluaスクリプトは、MA_01A112_57.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera005 = SetTemplate("Actor005",60,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
-- ▼直接出力
set_camera_nearclip(Camera002,1)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115179)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:名案があるんだけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_570002")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor004)
turn_chara(Actor003,-20,0)
lookat_weight(Actor001,0.7,0.03,0.7,0)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",2)
lookat_weight(Actor003,0.7,0.03,0.7,0)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",2)
set_enable_auto_lookat(Actor005,false)
-- ▲直接出力

	--★★アーサー★★:…ノワールとふたりで来てくれと<br>言ったはずだ、ギネヴィア
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A112_570003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor005,true)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:エレインはわたしたちの立役者だもん<br>聞く権利あるでしょ、その『聖域化』とかいうの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_570004")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Surprise")

	--★★エレイン★★:わ、私、お邪魔でしたら…
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_570005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A112_570007","MA_01A112_570008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,0.7,0.03,0.7,0)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",2)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィアは聞いて欲しいんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_570010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:当たり前でしょ<br>見届けて欲しいもん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_570011")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:継承者のキラーズがやんなきゃなんなくて<br>エレインが守ってくれたわたしがすべきこと
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_570012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
set_rot(Actor003,{0,-30,0})
lookat_weight(Actor002,0.7,0.03,0.7,0)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",2)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:エレイン、キミはどうしたい？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_570014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★エレイン★★:私わたしは…もしよろしいのであれば、知りたい<br>先輩とギネヴィアさんが背負う責務を
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_570015")

	change_face(Actor003,"Normal")

	--★★エレイン★★:そしてもしできることなら少しでも<br>その重荷が軽くなるよう手を貸してあげたいです
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_570016")

	PlayAction(Actor003,"to Greet_one")
	change_face(Actor003,"Smile")

	--★★エレイン★★:私の手は、空いてますから
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_570017")

	goto Block1end

::Block1end::
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力

	--★★マーリン★★:…よろしいです、いてください<br>口外厳禁としてくださるなら
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570019")

-- ▼直接出力
set_rot(Actor002,{0,-80,0})
lookat_delay_weight_reset(Actor001,1)
-- ▲直接出力

	--★★マーリン★★:信用できる方にしか、お話できないことです
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570020")

-- ▼直接出力
set_enable_auto_lookat_all(false)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Talk")
turn_chara(Actor003,-55,0.5)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★エレイン★★:…口ベタですから
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_570022")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat(Actor005,true)
lookat_delay_weight_reset(Actor002,1)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
turn_chara(Actor003,-20,0.5)
change_face(Actor003,"Normal")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:でね！さっき言ってた名案なんだけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_570023")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:聖杯って万人の願望を叶える器物の願望機なわけでしょ？<br>「バルバロイ全滅させて！」って願えばさ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_570024")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★マーリン★★:………聖杯が本当に<br>あまねく願いを叶えられれば、良いのですがね
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570026")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…聖杯は<br>願望を叶える器、<br>万物の願望機、というわけではない…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_570028")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Normal")

	--★★マーリン★★:そう…伝承されれば<br>人はそれを求めるでしょう？
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570029")


	--★★マーリン★★:なんとしても選ばれし者の手に渡すべく<br>そう伝えられたのだと思われます
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:なによその、いんちき…<br>じゃあなんのために私たち、探してきたわけ…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_570031")


	--★★マーリン★★:ただ、万人の望みを叶える杯であることに<br>変わりはありません
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570032")

	change_face(Actor003,"Surprise")

	--★★エレイン★★:万人の望み…？
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_570033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★マーリン★★:万人の望み…<br>大切な人との思い出や記憶、生きた証を残すこと
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570034")

	change_face(Actor005,"Anger")

	--★★マーリン★★:聖杯ならばそれを叶えられる…<br>──『聖域化』をなすことができる鍵です
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570035")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)

	--★★マーリン★★:この方法しかありません<br>無限に増殖し続けるバルバロイを封印するには
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570037")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:…全然納得できないけど結局、聖杯を使えば<br>バルバロイを全滅できるってことでいいわけ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_570039")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★マーリン★★:聖杯は、しかるべき場所でしか使えません
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570041")


	--★★マーリン★★:しかるべき場所<br>『サラスの都』への安置が絶対条件です
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:サラス…？
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_570043")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
-- ▲直接出力

	--★★アーサー★★:ブリテン最東部にある滅びた都だ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A112_570044")


	--★★マーリン★★:聖杯には万象の力が宿ると伝えられてます<br>つまり世の穢れに対抗できる武器たる力──
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570045")


	--★★マーリン★★:キラーズ因子が満ちた杯<br>それこそが聖杯です
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570047")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat_all(true)
-- ▲直接出力

	--★★エレイン★★:…聖杯自体がバルバロイに対抗するための──<br>『ブリテンの武器』ということだったんですね…
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_570048")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Anger")

	--★★マーリン★★:その強大な力ゆえ…しかるべき場所にて<br>見出された者にしか扱い切れません
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570050")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ルーシャスや魔女は…<br>それを防ごうとはしなかったんですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_570051")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★エレイン★★:そうですよね、サラスを制圧するとか…
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_570052")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★マーリン★★:彼らはサラスには入れませんでした<br>今サラスへの通り道は固く閉ざされているからです
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570053")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(false)
set_enable_auto_lookat(Actor005,true)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:じゃあわたしたちも入れないじゃん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_570054")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:ええ、ですが私がその門を開く儀式を行います<br>少しかかりますが…ご安心を
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570055")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…いまいち聖域化の具体的な手順が見えないわ<br>サラスに聖杯を安置して、それでおしまい？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_570056")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マーリン★★:………継承者がサラスに聖杯を安置すると<br>ブリテン全域に因子の力が染み渡ります
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570058")

	change_face(Actor003,"Surprise")

	--★★エレイン★★:バルバロイに相反するキラーズ因子の力を<br>島中に行きわたらせることができると…？
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_570059")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:はい。そうして聖域を形成する途上で<br>地を蝕んでいた穢れが浮き上がり──…
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★マーリン★★:最後に訪れるのが『、淘汰』蝕の刻
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570061")

	change_face(Actor003,"Normal")

	--★★エレイン★★:『蝕淘汰』…授業でやりましたが<br>歴史の節目に訪れるといわれる大いなる禍
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_570063")


	--★★マーリン★★:淘汰蝕に伴い<br>穢れの中心点が具現化します
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570064")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:穢れの中心点──<br>つまり、バルバロイの集合体のような？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_570066")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★マーリン★★:それを継承者のキラーズで貫き封じることで…<br>『聖域化』は成し遂げられます
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570068")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…──なんか、拍子抜けかも
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_570070")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:つまり<br>バルバロイの親玉を倒せばいいってこと？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_570071")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:はい…そうすることでこの地は『聖域』となり<br>継承者キラーズはバルバロイ根絶の封となる
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_570072")

-- ▼直接出力
lookat_delay_weight(Actor001,0.7,0.03,0.7,0,1)
-- ▲直接出力

	--★★ギネヴィア★★:封………
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_570074")

-- ▼直接出力
set_enable_auto_lookat_all(true)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Surp")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:………ちょっと待って
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_570076")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ギネヴィア？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_570077")

	change_face(Actor004,"Sad")

	--★★アーサー★★:…「きっかけは<br>錆びついた剣の軋み」
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A112_570078")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
wait_time(1)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(2)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115179)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
