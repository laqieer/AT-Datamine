-- このluaスクリプトは、MA_01A109_21.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",45,CharaPos110051_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_001)
	Camera006 = SetTemplate("Actor006",-83,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_007)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
load_image("101030470", "content_still_10103047_image", "101030470_StillImage")
load_image("102030020_StillImage", "content_still_10203002_image", "102030020_StillImage")
-- ▲直接出力
-- ▼直接出力
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1)
set_common_look_at(Actor001,Actor002,1)
-- ▲直接出力
-- ▼直接出力
tegami = setup_prop_object(10106003)
tegami_offset = {0,0,0,0,0,0}
off_active(tegami)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115054)
	Actor001 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_TextOnly()
	Actor010 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:学園内の重苦しい空気は払しょくされ<br>ローマとの戦いがいよいよ始まろうとしていた
	Talk(Actor010,"telop","narration","N","MA_01A109_211001")


	--★★テロップ★★:
	Talk(Actor010,"telop","narration","N","MA_01A109_211002")


	--★★テロップ★★:まるで公開処刑でしたね、陛下？
	Talk(Actor010,"telop","narration","N","MA_01A109_211003")


	--★★テロップ★★:笑いものにされ民衆の気分を高めるのも<br>王の役目のひとつだよ、マーリン
	Talk(Actor010,"telop","narration","N","MA_01A109_211004")

-- ▼直接出力
on_camera(RndCamera001)
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME+1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("マーリン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★マーリン★★:まるで公開処刑でしたね、陛下？
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01A109_210002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:笑いものにされ民衆の気分を高めるのも<br>王の役目のひとつだよ、マーリン
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_210003")

-- ▼直接出力
on_camera(Camera003)
change_face(Actor002,"Normal")
change_face(Actor001,"Normal")
lookat_delay_weight_reset(Actor002,0.6)
lookat_delay_weight_reset(Actor001,0.6)
SkipOffsetCamera(Camera003)
-- ▲直接出力

	--★★知将ケイ★★:殿下の──<br>あいや失礼、ギネヴィア様の──
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01A109_210004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:いつも通りでいいわ<br>呼び捨てでも構わないし
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_210005")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★知将ケイ★★:いいえ<br>称えさせていただきたい
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01A109_210007")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ギネヴィア★★:…もお。好きにして
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_210009")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★知将ケイ★★:ギネヴィア様の演説により<br>士気はこれまでにないほど高まりを見せている
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01A109_210010")

	change_face(Actor003,"Sad")

	--★★知将ケイ★★:虐殺の嫌疑が晴れたわけではないが…
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01A109_210011")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:晴らさんとする者が奮起するには<br>じゅうぶんすぎるほど派手なやりかただったよ
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01A109_210012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★マーリン★★:ロンディニウムはいまだ『ログレス軍』の制圧下<br>つまりはローマの息がかかった者が駐留している
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01A109_210013")

-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★知将ケイ★★:なにが待ち受けているか<br>想像に難くはないな
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01A109_210015")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:ロンディニウムを占領してる奴らを<br>縛り上げちまえば真偽もハッキリするぜ…！
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01A109_210016")

-- ▼直接出力
CloseTalkWindow()
show_image("102030020_StillImage", 0.0, 0.0, 0.3,false,false)
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:ブリテン東部では<br>カレドニアの残党もローマにやられたと聞く
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_210017")


	--★★知将ケイ★★:…島東部はほぼ<br>ローマに制圧されたか
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01A109_210018")

-- ▼直接出力
CloseTalkWindow()
hide_image(0.3)
 --PlayPartVoice("アーサー", "落胆")
-- ▲直接出力

	--★★アーサー★★:ローマも動き出す頃合いだ<br>こちらの態勢が整い切っているわけではないが…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_210019")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ギネヴィア★★:殴り込みましょ。さっさとね
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_210020")

	open_select_window_tag(Actor005,"Normal","MA_01A109_210022","MA_01A109_210023","MA_01A109_210024")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Surprise")

	--★★ノワール★★:君はすごいな、ギネヴィア
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01A109_210026")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ギネヴィア★★:今頃気づいた？
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_210027")

	PlayAction(Actor005,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ノワール★★:いいや、ずっとそう思っていたよ
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01A109_210028")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:頑張ろう、ガウェイン
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01A109_210030")

	change_face(Actor006,"Normal")

	--★★ガウェイン★★:…ああ
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01A109_210031")

	change_face(Actor005,"Normal")

	--★★ノワール★★:…ガウェイン？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01A109_210032")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ノワール★★:確か同行を希望していた人がいたような…
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01A109_210034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:ああ、希望は承っている。そろそろ来るはずだ<br>ひとりでも戦力が欲しいところだからな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_210035")

	change_face(Actor004,"Normal")

	--★★ギネヴィア★★:ね。だあれ？
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_210036")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★マーリン★★:アーサー様は聖杯探索班のフォローがあります<br>ご助力はできませんが…
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01A109_210038")

-- ▼直接出力
CloseTalkWindow()
set_common_look_at(Actor006,Actor007,1)
EntryWalk_2P(Actor007,Camera007,EntryData110051_01_03,CameraAssetBundleName110051_01,CameraPos110051_01_103,Actor008,CharaPos110051_01_007,CharaPos110051_01_107)
-- ▲直接出力
	PlayAction(Actor007,"to Bow")
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "挨拶")
-- ▲直接出力

	--★★ラヴェイン★★:遅参しました
	Talk(Actor007,"CHRNAME_LOVEIN","speech","L","MA_01A109_210040")

	PlayAction(Actor008,"to  Std_Sad01")
	change_face(Actor008,"Sad")

	--★★エレイン★★:…
	Talk(Actor008,"CHRNAME_ELAINE","speech","L","MA_01A109_210041")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★ガウェイン★★:あんたら確か、ロンディニウムからの──
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01A109_210042")

-- ▼直接出力
setup_small_camera_end(Camera007)
turn_chara(Actor004, 34.5, 0)
SkipOffsetCamera(Camera007)
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力

	--★★ラヴェイン★★:同行の許可を<br>アーサー王より頂戴いたしました
	Talk(Actor007,"CHRNAME_LOVEIN","speech","L","MA_01A109_210043")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
setup_small_camera_start(Camera004)
change_face(Actor006,"Normal")
change_face(Actor005,"Normal")
turn_chara(Actor005, 69, 0)
turn_chara(Actor008, 187.5, 0)
wait_time(0.4)
fadeout(0,0,0,1.0,2.0)
PlayActionDirect(Actor008,"to LookFor")
wait_time(1.5)
PlayActionDirect(Actor008,"to Show")
wait_time(0.5)
PlayActionDirect(Actor008,"to Std_Loop")
show_image("101030470", 0.0, 0.0, 0,true,false)
fadein(1.5)
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ギネヴィア★★:…手紙？
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_210045")

	change_face(Actor004,"Normal")

	--★★ギネヴィア★★:…見てみても？
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_210047")

-- ▼直接出力
CloseTalkWindow()
hide_image(0)
play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
wait_time(1.0)
setup_small_camera_start(RndCamera005)
turn_chara(Actor007, 270, 0)
set_enable_auto_lookat(Actor007,false)
lookat_weight(Actor007,1.0,0.5,1.0,0.5)
keep_delay_ik_lookat(Actor007,Actor004,"J_Head",0.5)
Hide(Actor006)
Hide(Actor007)
PlayActionDirect(Actor004,"to ReadLetter")
SkipDefaultMotion(Actor004)
on_active(tegami)
on_parent(tegami,Actor004, "Loc_weapon_constrint_L", tegami_offset)
wait_time(1.0)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ギネヴィア★★:…<br>こんなこと、はじめて言われた
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_210049")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:…お言葉を、きかせてください
	Talk(Actor008,"CHRNAME_ELAINE","speech","L","MA_01A109_210051")

	change_face(Actor004,"Normal")

	--★★ギネヴィア★★:………弱音は、飾り立てちゃう
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_210052")

-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor008,"Surprise")

	--★★エレイン★★:…飾る
	Talk(Actor008,"CHRNAME_ELAINE","speech","L","MA_01A109_210053")

-- ▼直接出力
setup_small_camera_end(Camera004)
Appear(Actor006)
Appear(Actor007)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
off_parent(tegami)
off_active(tegami)
SkipOffsetCamera(Camera004)
set_common_look_at(Actor004,Actor008,0.7)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ギネヴィア★★:怯えた声は飲み込むの<br>口下手なら余計にね
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_210054")

	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★エレイン★★:…それは、辛くはありませんか
	Talk(Actor008,"CHRNAME_ELAINE","speech","L","MA_01A109_210055")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ギネヴィア★★:超しんどいよ、もちろんね
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_210056")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ギネヴィア★★:だけど手を引いてくれた人たちがいるから<br>わたしを見出してくれた人たちがいるから
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_210057")


	--★★ギネヴィア★★:わたしは戦う
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_210058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ギネヴィア★★:やられっぱなしじゃいられないでしょ？
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_210059")

-- ▼直接出力
setup_small_camera_start(Camera008)
turn_chara(Actor004, CharaPos110051_01_002[4], 0)
lookat_delay_weight_reset(Actor005,1)
lookat_delay_weight_reset(Actor004,1)
lookat_delay_weight_reset(Actor006,1)
-- ▲直接出力
	change_face(Actor008,"Surprise")

	--★★エレイン★★:…！
	Talk(Actor008,"CHRNAME_ELAINE","speech","L","MA_01A109_210060")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor004,"Normal")

	--★★ギネヴィア★★:スタンド・バイ・ユアラウンド
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","N","MA_01A109_210062")

	close_cutin()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★一同★★:フォー・ラウンド！
	Talk(Actor009,"NPCNAME_0126","speech","N","MA_01A109_210064")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101030470", "content_still_10103047_image", "101030470_StillImage")
load_image_preload("102030020_StillImage", "content_still_10203002_image", "102030020_StillImage")
setup_prop_object_preload(10106003)
tegami_offset = {0,0,0,0,0,0}
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115054)
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
