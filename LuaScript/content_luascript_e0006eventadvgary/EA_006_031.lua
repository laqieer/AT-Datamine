-- このluaスクリプトは、EA_006_031.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor002",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera002 = SetTemplate("Actor003",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	Camera003 = SetTemplate("Actor004",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera004 = SetTemplate("Actor005",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera005 = SetTemplate("Actor006",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera006 = SetTemplate("Actor007",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera007 = SetTemplate("Actor008",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera008 = SetTemplate("Actor009",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera009 = SetTemplate("Actor010",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera010 = SetTemplate("Actor012",nil,CharaPos110051_02_019,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_019)
	Camera011 = SetTemplate("Actor013",nil,CharaPos110051_02_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_021)
	Camera012 = SetTemplate("Actor014",nil,CharaPos110051_02_020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_020)
	Camera013 = SetTemplate("Actor015",nil,CharaPos110051_02_014,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_014)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor012,Actor013,0)
turn_lookat(Actor013,Actor012,0)
turn_lookat(Actor015,Actor002,0)
set_pos(Actor014, {0.01, 0.035, -4.2})
turn_chara(Actor014,180,0)
set_enable_auto_lookat(Actor012,false)
set_enable_auto_lookat(Actor013,false)
set_enable_auto_lookat(Actor014,false)
change_face(Actor010,"Angry")
change_face(Actor011,"Angry")
-- ▲直接出力
-- ▼直接出力
Hide(Actor015)
Hide(Actor012)
Hide(Actor013)
Hide(Actor014)
-- ▲直接出力
-- ▼直接出力
load_image("103020020", "content_still_10302002_image", "103020020_StillImage")
-- ▲直接出力
-- ▼直接出力
Camera_EX =set_camera({-1.58, 1.98, -11.229,   9, 17.37, 0,   25})
Camera_EX2 =set_camera({2.256, 2.398, 0.07,   15, 332.598, 0,   27})
-- ▲直接出力
-- ▼直接出力
prop001 = setup_prop_object(10106003)
prop002 = setup_prop_object(10106003)
prop003 = setup_prop_object(10106004)
-- ▲直接出力
-- ▼直接出力
set_pos(prop001,{-0.193, 0.944, 5.12})
set_pos(prop002,{-0.38, 0.944, 4.982})
set_pos(prop003,{0.006, 0.944, 5.129})
-- ▲直接出力
-- ▼直接出力
set_rot(prop001,{0,0,180})
set_rot(prop002,{0,30,180})
set_rot(prop003,{0,140,0})
-- ▲直接出力
-- ▼直接出力
Camera_MOR2 =set_camera({2.41, 1.22, -8.27,   358.164, 305.682, 0,   20})
Camera_GAW2 =set_camera({-0.56, 1.35, -9.14,   0, 24.24399, 0,   20})
Camera_ART2 =set_camera({0.915, 1.162, 2.883,   2.00001, 341.014, 0,   16.1457})
Camera_GAR2 =set_camera({-0.73, 1.15, 3.67,   359, 30.774, 0,   20})
Camera_LAN2 =set_camera({1.1, 1.13, 4.78,   0, 284.69, 0,   16.1457})
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
DontCameraOffset(Actor003)
DontCameraOffset(Actor004)
DontCameraOffset(Actor005)
DontCameraOffset(Actor006)
DontCameraOffset(Actor007)
DontCameraOffset(Actor008)
DontCameraOffset(Actor009)
DontCameraOffset(Actor010)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101032","002","101032002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_TextOnly()
	Actor012 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor012")
	Actor013 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor013")
	Actor014 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor014")
	Actor015 = InitializeCharacter_3D("101032","002","101032002","content_animationpack__common","FacialPack","Actor015")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor015,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:数日後
	Talk(Actor001,"telop","simple","N","EA_006_0310004")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:続々と感謝のおたよりが届いているなぁ！<br>一部、読み上げてみようか
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★アーサー★★:「街道で盗賊に襲われもう駄目かと思ったとき<br>颯爽とガレスさんが現れ助けてくれました」
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:「バルバロイの討伐任務に出ていたら<br>増援のバルバロイに囲まれ、絶体絶命」
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310008")


	--★★アーサー★★:「死を覚悟していたら、見回り中のガレスが<br>加勢してくれて事なきを得ました」
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310009")


	--★★アーサー★★:「弱きを助けるガレス、まさに円卓の騎士」<br>「円卓の騎士、サイコー！」…と
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0008")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:いやあ、まさに獅子奮迅の大活躍<br>といったところか。すごいな、ガレス！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310011")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Shy")

	--★★ガレス★★:いやあ、それほどでも～
	Talk(Actor003,"CHRNAME_GARETH","speech","L","EA_006_0310012")

	change_face(Actor002,"Normal")

	--★★アーサー★★:これだけ結果を出しているんだ<br>皆もそろそろ彼女を快く認めてはどうだ？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力

	--★★トリスタン★★:まぁ、そうだね。諜報部隊も<br>かなり彼女に助けられたと聞いているし
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","EA_006_0310014")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:円卓の騎士の名に<br>ふさわしい働きをしたんじゃない
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","EA_006_0310015")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0009")
-- ▲直接出力

	--★★パーシヴァル★★:ぼくも認めていいよ
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_006_0310016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★パーシヴァル★★:彼女が雑用をこなしてくれるおかげで<br>ぼくの崇高な任務に集中することができたしね
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_006_0310017")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:ふたり、こっち側に引き込んだぞ！<br>やったな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310018")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Laugh")

	--★★ガレス★★:はい！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","EA_006_0310019")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)

	--★★ガウェイン★★:俺は反対だからな
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","EA_006_0310020")

	change_face(Actor003,"Anger")

	--★★ガレス★★:ふんだ！<br>兄さんには聞いてないから！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","EA_006_0310021")

	play_head_motion(Actor007, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0014")
-- ▲直接出力

	--★★モルドレッド★★:おいおい、オレのことも忘れんなよ
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","EA_006_0310023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルドレッド★★:そんなちゃちな戦功で認められるたぁ<br>円卓も舐められたモンだな
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","EA_006_0310025")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0025")
-- ▲直接出力

	--★★トリスタン★★:キミはただアーサー様の決定に<br>噛みつきたいだけでしょ
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","EA_006_0310026")

	change_face(Actor007,"Anger")

	--★★モルドレッド★★:あ？なんか言ったか
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","EA_006_0310027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:オホン…モルドレッドの言い分は乱暴ではあるが<br>私も概ね同じ意見だ
	Talk(Actor008,"CHRNAME_KAY","speech","L","EA_006_0310028")


	--★★ケイ★★:言ってはなんだが、ガレスがこなしてきた任務は<br>円卓の任務としてはランクの低いもの
	Talk(Actor008,"CHRNAME_KAY","speech","L","EA_006_0310029")

	play_head_motion(Actor008, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ケイ","0008")
-- ▲直接出力

	--★★ケイ★★:円卓の騎士としての資質を示したというには<br>足りないと言わざるを得ん
	Talk(Actor008,"CHRNAME_KAY","speech","L","EA_006_0310030")

-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0007")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★モルドレッド★★:あの厄介な連中をブッ潰しでもしてくれたら<br>快く認めてやってもいいぜ
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","EA_006_0310031")

	change_face(Actor007,"Normal")

	--★★モルドレッド★★:なんだっけ？確か――<br>「<ruby=ラ・コート・マルタイユ>不格好なコート</ruby>」だったか？
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","EA_006_0310032")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Anger")

	--★★ガウェイン★★:…オイ！なに言ってんだ<br>そんなことさせるワケねーだろ！！
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","EA_006_0310034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0019")
-- ▲直接出力
	change_face(Actor009,"Sad")

	--★★ヴォールス★★:落ち着け、ガウェイン
	Talk(Actor009,"CHRNAME_BORS","speech","L","EA_006_0310035")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor009)
Hide(Actor006)
Hide(Actor007)
Appear(Actor012)
Appear(Actor014)
Appear(Actor013)
setup_small_camera_start(Camera_EX)
wait_time(0.4)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(1.0)
PlayActionDirect(Actor013,"to  Std_Talk")
wait_time(1.8)
PlayActionDirect(Actor012,"to  Std_Talk")
wait_time(1.8)
PlayActionDirect(Actor014,"to  Std_No")
wait_time(2.0)
PlayActionDirect(Actor013,"to Std_Loop")
PlayActionDirect(Actor012,"to Std_Loop")
PlayActionDirect(Actor014,"to Std_Loop")
setup_small_camera_end(Camera_EX)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0034")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガレス★★:「不格好なコート」って？
	Talk(Actor003,"CHRNAME_GARETH","speech","L","EA_006_0310038")


	--★★トリスタン★★:カレドニアが雇っている傭兵団だよ<br>そこまで大きな団ではないけど…
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","EA_006_0310039")


	--★★トリスタン★★:
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","EA_006_0310040")

	change_face(Actor005,"Sad")

	--★★パーシヴァル★★:
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_006_0310041")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0019")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★パーシヴァル★★:おかげで『探し物』は遅々と進まず<br>皆のイライラは募るばかりってわけ
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_006_0310042")


	--★★ガレス★★:ふーん…
	Talk(Actor003,"CHRNAME_GARETH","speech","L","EA_006_0310043")


	--★★トリスタン★★:
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","EA_006_0310044")

	change_face(Actor003,"Surprise")

	--★★ガレス★★:え…
	Talk(Actor003,"CHRNAME_GARETH","speech","L","EA_006_0310045")

	change_face(Actor004,"Sad")

	--★★トリスタン★★:
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","EA_006_0310046")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★トリスタン★★:
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","EA_006_0310047")

-- ▼直接出力
setup_small_camera_start(Camera_GAW2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0016")
-- ▲直接出力
	change_face(Actor013,"Anger")

	--★★ガウェイン2★★:大体お前は――！
	Talk(Actor013,"CHRNAME_GAWAIN","speech","L","EA_006_0310048")

-- ▼直接出力
setup_small_camera_end(Camera_GAW2)
setup_small_camera_start(Camera_MOR2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0013")
-- ▲直接出力
	change_face(Actor012,"Anger")

	--★★モルドレッド2★★:
	Talk(Actor012,"CHRNAME_MORDRED","speech","L","EA_006_0310049")

-- ▼直接出力
setup_small_camera_end(Camera_MOR2)
setup_small_camera_start(Camera_EX)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor013,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガレス★★:（…なんか、円卓って<br>いっつも喧嘩してるんだな～）
	Talk(Actor003,"CHRNAME_GARETH","mind","L","EA_006_0310052")

-- ▼直接出力
PlayActionDirect(Actor012,"to  Std_Talk")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガレス★★:（せっかく皆で集まってるんだし<br>どうせならもっと皆仲良くしたいのに…）
	Talk(Actor003,"CHRNAME_GARETH","mind","L","EA_006_0310053")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor013,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor012,"to Std_Loop")
PlayActionDirect(Actor014,"to  Std_Sad02")
wait_time(2.0)
setup_small_camera_end(Camera_EX)
PlayActionDirect(Actor014,"to Std_Loop")
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ガレス★★:（うーん…――あ、そうだ♪）
	Talk(Actor003,"CHRNAME_GARETH","mind","L","EA_006_0310054")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_end(Camera_EX)
Hide(Actor014)
Hide(Actor013)
Hide(Actor012)
Hide(Actor004)
Hide(Actor008)
Hide(Actor005)
Hide(Actor003)
Appear(Actor015)
setup_small_camera_start(Camera_EX)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(1.2)
setup_small_camera_end(Camera_EX)
setup_small_camera_start(Camera_ART2)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:花見？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310058")

-- ▼直接出力
setup_small_camera_end(Camera_ART2)
setup_small_camera_start(Camera_GAR2)
-- ▲直接出力
	play_head_motion(Actor015, "Nod", 0.3, 1.0, false)
	change_face(Actor015,"Smile")

	--★★ガレス2★★:そう！ちょうど今、春になって<br>野に綺麗な花が咲く季節だろ～？
	Talk(Actor015,"CHRNAME_GARETH","speech","L","EA_006_0310059")

	change_face(Actor015,"Laugh")

	--★★ガレス2★★:
	Talk(Actor015,"CHRNAME_GARETH","speech","L","EA_006_0310060")

-- ▼直接出力
setup_small_camera_end(Camera_GAR2)
setup_small_camera_start(Camera_EX2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0010")
-- ▲直接出力

	--★★ガレス2★★:
	Talk(Actor015,"CHRNAME_GARETH","speech","L","EA_006_0310061")

	PlayAction(Actor015,"to  Std_Talk")

	--★★ガレス2★★:みんなでちょっと遠出して、いつもと違う場所で<br>手作りのお弁当を食べながら同じ花を眺めて
	Talk(Actor015,"CHRNAME_GARETH","speech","L","EA_006_0310062")

	change_face(Actor015,"Smile")

	--★★ガレス2★★:
	Talk(Actor015,"CHRNAME_GARETH","speech","L","EA_006_0310063")


	--★★ガレス2★★:そんなふうにしてたらすごく楽しくて…<br>なんで喧嘩したのかも忘れちゃったんだ～
	Talk(Actor015,"CHRNAME_GARETH","speech","L","EA_006_0310064")

	play_head_motion(Actor015, "Nod", 0.3, 1.0, false)
	change_face(Actor015,"Laugh")

	--★★ガレス2★★:…そんなことがあったんだ
	Talk(Actor015,"CHRNAME_GARETH","speech","L","EA_006_0310065")

-- ▼直接出力
CloseTalkWindow()
CloseTalkWindow()
show_image("103020020", 0.0, 0.0, 0.8,true,false)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
	change_face(Actor011,"Normal")

	--★★オークニー王妃★★:ねえ、ガレス。こうやって家族皆で笑い合って<br>ずっと仲良しがいいわね
	Talk(Actor011,"NPCNAME_0395","simple","N","EA_006_0310069")


	--★★オークニー王妃★★:今はここにいないあの子もいつか…
	Talk(Actor011,"NPCNAME_0395","simple","N","EA_006_0310070")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
	change_face(Actor015,"Sad")

	--★★ガレス2★★:………
	Talk(Actor015,"CHRNAME_GARETH","speech","L","EA_006_0310073")

-- ▼直接出力
setup_small_camera_end(Camera_EX2)
setup_small_camera_start(Camera_ART2)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310074")


	--★★アーサー★★:円卓がなんかピリピリしてギスギスしてるから<br>花見でもして和んだ方がいい！というわけだな？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310075")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0046")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:いいじゃないか！今後の戦いに向けて<br>円卓の結束を高めるのはいいことだ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310076")

-- ▼直接出力
setup_small_camera_end(Camera_ART2)
setup_small_camera_start(Camera_EX2)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310077")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★アーサー★★:そんな状況で皆、心の余裕もなく<br>円卓はバラバラ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310078")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:確かに、今のままじゃいかんなあとは<br>思っていたんだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310079")

	PlayAction(Actor015,"to  Std_Joy")
	change_face(Actor015,"Surprise")

	--★★ガレス2★★:じゃあ、協力してくれるのか？
	Talk(Actor015,"CHRNAME_GARETH","speech","L","EA_006_0310080")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310081")

-- ▼直接出力
setup_small_camera_end(Camera_EX2)
setup_small_camera_start(Camera_LAN2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0030")
-- ▲直接出力
	change_face(Actor010,"Surprise")

	--★★ランスロット★★:おい、アーサー<br>なにを勝手に…
	Talk(Actor010,"CHRNAME_LANCELOT","speech","L","EA_006_0310082")

-- ▼直接出力
setup_small_camera_end(Camera_LAN2)
setup_small_camera_start(Camera_GAR2)
-- ▲直接出力
	PlayAction(Actor015,"to  Std_Talk")
	change_face(Actor015,"Smile")

	--★★ガレス2★★:
	Talk(Actor015,"CHRNAME_GARETH","speech","L","EA_006_0310083")

-- ▼直接出力
setup_small_camera_end(Camera_GAR2)
setup_small_camera_start(Camera_ART2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0009")
-- ▲直接出力

	--★★アーサー★★:綺麗な花を見て、皆で輪になって<br>宴をすれば、心もひとつになるだろう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310084")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★アーサー★★:――ああ、そうだ<br>宴には美味い食事が必要不可欠だな？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310085")

-- ▼直接出力
setup_small_camera_end(Camera_ART2)
setup_small_camera_start(Camera_EX2)
-- ▲直接出力
	change_face(Actor015,"Surprise")

	--★★ガレス2★★:
	Talk(Actor015,"CHRNAME_GARETH","speech","L","EA_006_0310087")

	play_head_motion(Actor015, "Nod", 0.3, 1.0, false)
	change_face(Actor015,"Laugh")

	--★★ガレス2★★:皆の心を「美味しい」でひとつにしちゃう<br>とっておきのご飯を作ってみせるぞ♪
	Talk(Actor015,"CHRNAME_GARETH","speech","L","EA_006_0310088")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:うむ。頼んだぞ<br>お前にしかできないことだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0310089")

-- ▼直接出力
PlayPartVoiceDirect("ガレス","0007")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Laugh")
	change_face(Actor015,"Normal")

	--★★ガレス2★★:
	Talk(Actor015,"CHRNAME_GARETH","speech","N","EA_006_0310090")

	close_cutin()
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("103020020", "content_still_10302002_image", "103020020_StillImage")
setup_prop_object_preload(10106003)
setup_prop_object_preload(10106003)
setup_prop_object_preload(10106004)
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101032","002","101032002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor012")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor013")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor014")
	InitializeCharacter_3D_Preload("101032","002","101032002","content_animationpack__common","FacialPack","Actor015")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor015,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
