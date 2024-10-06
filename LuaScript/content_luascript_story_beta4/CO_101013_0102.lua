-- このluaスクリプトは、CO_101013_0102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_02","110011_02_h")
Include("content_adv_advsmall_110011_02","Template110011_02_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_006)
	InitializeTemplateRandomCamera110011_02()
	InitializeTemplate110011_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:で、ガウェインの憧れてる<br>ふたりのヒーローって誰なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020002")


	--★★ノワール★★:ひとりはアーサーか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:おうよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:アーサー様は<br>王様だってのに誰よりも前に出て行ける方だ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:カッコいいよな！<br>シビれるよな！憧れるよな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020006")

	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:しかも、それだけじゃなくて<br>俺みてーに強さにムラッ気のあるヤツを
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020008")


	--★★ガウェイン★★:円卓の騎士に取り立ててくれた<br>言ってみれば恩人なんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020009")

-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:だから<br>俺は一生あの人についていくって決めてる
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020010")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:尊敬を通り越して<br>もはや忠犬みたいになっちゃってるよね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_01020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:うっせ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それだけ慕われたら<br>アーサーも嬉しいだろうなあ、きっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:で、もうひとりのヒーローってのは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:…俺とラグネルが子供の頃さ<br>住んでた街が野盗に狙われたんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020015")


	--★★ガウェイン★★:そいつらは入れ替わり立ち替わりやって来ては<br>街を荒らしていった
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020016")

-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:抵抗の意志を見せる大人たちもいたんだけど<br>次第にその数は減って、最後は泣き寝入り
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_01020017")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:数十人くらいの規模になっていたから<br>無理もないんだけどな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020018")


	--★★ガウェイン★★:俺とラグネルは、もうこれ以上我慢できねえって<br>ヤツらのアジトに乗り込んだんだけど
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020019")

-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:ガキふたりじゃ大人にはかなわなくてよ<br>すぐに取り押さえられて、やられそうになった
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:そんなときさ。ひとりのローマ兵士が<br>俺たちを救ってくれたんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020021")

-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:しかも、そのあと野盗を壊滅させて<br>俺たちの住んでた街も救ってくれた
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020022")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:もうめちゃくちゃ強かったよね！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_01020023")

	open_select_window_tag(Actor001,"Normal","CO_101013_01020025","CO_101013_01020026")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:たったひとりで？<br>それはすごいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020028")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:俺たちもビックリしたぜ<br>それまでみたどの大人よりも強かった
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:いや、今でもあの人より腕の立つヤツって<br>ほとんど見たことねーかも
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020030")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:一介の兵士がそんなに強かったのか？<br>名のある将軍とかだったんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020031")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:あの人の素性は<br>俺たちも良く知らなかったんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020032")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:あんまり自分のこと<br>言いたがらねえ人だったから
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020034")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:俺たちの街に来た理由も<br>「たまたま通りがかった」とか言ってたしね
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020035")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:たったひとりで野盗を壊滅？<br>それは話を盛り過ぎじゃないか～？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020037")

-- ▼直接出力
PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:それが本当なんだって<br>信じられねえだろうけどさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020038")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:ガウェインはともかくとして<br>あたしも見てるんだから、本当は本当だよ
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_01020039")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:俺はともかくとして、って<br>どういうことだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020040")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ラグネルがそういうなら信じるか<br>ガウェインはともかくとして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020041")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:だから！俺はともかくとして、って<br>どういうことなんだよっ！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020042")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:その人は野盗を懲らしめたあともさ<br>壊された家の修理とかケガ人の手当てとか
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_01020044")


	--★★ラグネル★★:みんなのためにいろんなことを<br>してくれたんだよね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_01020045")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ラグネル★★:誰かが口にするより早く<br>願いをくみ取ったみたいに颯爽と現れてさ
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_01020046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そんな人が本当にいるんだなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020047")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ラグネル★★:そりゃあガウェイン少年も<br>「俺もヒーローになる！」って言いだすよね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_01020048")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:あんなすごい人を見ちまったら<br>憧れるに決まってんだろ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020050")

-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:気持ちはわかるけどね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_01020051")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:昔っから変わらないんだな、ガウェインは<br>ところでラグネルは？どんな子供だったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020052")

	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:ラグネルこそ今と変わんないだろ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ラグネル★★:ガウェインだけじゃない？<br>あたしが変わってないって思ってるのは
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_01020054")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:そうか～？<br>今も昔もずーっと変わらずお転婆だろ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:あの人に言われただろ<br>向こう見ずなところは直したほうがいいって
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020056")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力

	--★★ラグネル★★:ガウェインこそ言われてたでしょ<br>周りをちゃんと見ろとか
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_01020057")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まぁまぁ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020059")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それにしても<br>その人に大きな影響を受けたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020061")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:たぶん俺はずっと<br>ししょーの背中を追ってるんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020062")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ししょー…師匠？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020064")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:そう、ししょー。たたずまいに師匠感があったし<br>名前も長かったからさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020065")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:師匠感ってのはよくわかんないけど<br>それで、その人は今、どこでなにをしてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020067")


	--★★ノワール★★:それだけすごい人なら、どこかの戦場で活躍して<br>有名になってるんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_01020068")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力

	--★★ガウェイン★★:そうだな<br>活躍の場をローマの外まで広げてたりするかもな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_01020070")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_acquired("ガウェイン_コミュランク", "ガウェイン_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
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
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
MobsNo = 1
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
