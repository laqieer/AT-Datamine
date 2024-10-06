-- このluaスクリプトは、EA_009_052.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_01","110091_01_h")
Include("content_adv_advsmall_110091_01","Template110091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_005)
	Camera002 = SetTemplate("Actor002",13,CharaPos110091_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110091_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_002)
	Camera006 = SetTemplate("Actor007",nil,CharaPos110091_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_001)
	Camera007 = SetTemplate("Actor008",nil,CharaPos110091_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_006)
	Camera008 = SetTemplate("Actor009",nil,CharaPos110091_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_007)
	Camera009 = SetTemplate("Actor010",nil,CharaPos110091_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_001)
	Camera010 = SetTemplate("Actor011",nil,CharaPos110091_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_006)
	Camera011 = SetTemplate("Actor012",nil,CharaPos110091_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_007)
	Camera012 = SetTemplate("Actor013",nil,CharaPos110091_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_001)
	InitializeTemplateRandomCamera110091_01()
	InitializeTemplate110091_01()
-- ▼直接出力
set_pos(Actor004, {-0.718, 0, -1.05})
set_pos(Actor003,{0.413, 0, -2.34})
set_pos(Actor005,{-0.109, 0, -1.33})
turn_chara(Actor003, 12,0)
turn_chara(Actor004, 19,0)
turn_chara(Actor005,347,0)
Hide(Actor004)
Hide(Actor003)
Hide(Actor005)
set_enable_auto_lookat(Actor001,false)
set_pos(Actor007, {2.58067, 0, 6.93356})
turn_chara(Actor007,116,0)
set_pos(Actor008, { -0.32301, 0, 7.83171})
turn_chara(Actor008,231,0)
set_pos(Actor009,{4.11, 0, 7.72643})
turn_chara(Actor009, 220,0)
set_pos(Actor010, {3.6288, 0, 6.1447})
turn_chara(Actor010,313,0)
set_pos(Actor011, { 3.46793, 0, 8.40093})
turn_chara(Actor011,162,0)
set_pos(Actor012, { -0.2064, 0, 6.30883})
turn_chara(Actor012, 313,0)
set_pos(Actor013, { -1.64775, 0, 7.09236})
turn_chara(Actor013, 90,0)
-- ▲直接出力
-- ▼直接出力
Camera_EX = set_camera({1.881, 2.34, 0.578,   15.61851, 352.6838, 359.8971,   21.50124})
-- ▲直接出力
-- ▼直接出力
load_image("104000290", "content_still_10400029_image", "104000290_StillImage")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007,false)
set_enable_auto_lookat(Actor008,false)
set_enable_auto_lookat(Actor009,false)
set_enable_auto_lookat(Actor010,false)
set_enable_auto_lookat(Actor011,false)
set_enable_auto_lookat(Actor012,false)
set_enable_auto_lookat(Actor013,false)
-- ▲直接出力
-- ▼直接出力
Camera_EX2 = set_camera({0.13, 3.37, -3.49,   15.61853, 15.45324, 359.8971,   21.50124})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{7.39, 0, 1.32})
turn_chara(Actor002,297,0)
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110091)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	Actor007 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_3D("401022","001","401022001","content_animationpack__common","FacialPack","Actor012")
	Actor013 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor013")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そろそろ開演か…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520004")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
setup_small_camera_start(Camera_EX2)
Appear(Actor002)
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
wait_time(0.2)
slidemove(Actor002,{2.725, 0, 4.167},3.9)
wait_time(3.9)
turn_lookat(Actor002,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ラヴェイン★★:ディナタンさんが心配ですか？
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520005")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor002,1.0)
wait_time(1.0)
PlayActionDirect(Actor001,"to Std_Loop")
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ラヴェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520006")

	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:ノワール君、私は君に謝らなくてはなりません<br>ディナタンさんに多くを背負わせすぎてしまった
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520007")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520008")

	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:本来であれば生徒会長である私が先頭に立って<br>生徒たちを励ますべきなんです
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520009")

-- ▼直接出力
setup_small_camera_end(Camera_EX2)
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ラヴェイン★★:けれど私は彼女の優しさに甘えてしまった<br>甘えて――期待してしまった
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520010")

-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:それはきっと、彼女の重荷になったことでしょう<br>だから彼女の声は奪われてしまった
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520011")

-- ▼直接出力
setup_small_camera_end(Camera002)
setup_small_camera_start(Camera_EX2)
-- ▲直接出力

	--★★ノワール★★:…え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520012")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520013")


	--★★ラヴェイン★★:そしてそのほとんどが、私たちが<br>魔術師を倒すよりも先に回復していた
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520015")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力

	--★★ノワール★★:…！どういうことだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520016")


	--★★ラヴェイン★★:力を失ったのはあくまで一時的だったんです
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520017")

-- ▼直接出力
setup_small_camera_end(Camera_EX2)
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ラヴェイン★★:キッスさんの追加調査によれば<br>冒険者たちもすぐに回復していたとか
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520018")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:これは私の推測ですが…恐らく彼には<br>他者の力を奪う能力などなかったのではないかと
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520019")

-- ▼直接出力
setup_small_camera_end(Camera002)
setup_small_camera_start(Camera_EX2)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:例えば魔法で対象の精神を一時的に不安定にし<br>身体的なトラブルを生じさせる
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラヴェイン★★:それによって力を奪ったと思い込んでいた…<br>そう考えるのが自然だと思います
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520021")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:精神的に不安定に…<br>じゃあ、ディナタンは――…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520022")

	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520023")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…いや、もしそうだとしても――<br>一番責任があるのは俺だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520024")

-- ▼直接出力
setup_small_camera_end(Camera_EX2)
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺がもっとしっかりしていれば<br>ディナタンに心配をかけることもなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520025")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラヴェイン★★:ノワール君…
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520026")

-- ▼直接出力
setup_small_camera_end(Camera002)
setup_small_camera_start(Camera_EX2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")

	--★★ノワール★★:大切な人も守れず、家族に心配かけて<br>継承者なんてろくなもんじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520027")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…なんでアイツはあそこまで<br>継承者に拘ったんだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520028")

	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:…少し前に、とある村が<br>バルバロイの襲撃によって壊滅しました
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520029")


	--★★ラヴェイン★★:その村に、ひとりの魔術師がいたそうです<br>彼は継承者に強い憧れを持っていた
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520030")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:蔓延るバルバロイの脅威から<br>いつか、継承者が世界を救うのだと
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520031")

-- ▼直接出力
setup_small_camera_end(Camera_EX2)
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520032")

-- ▼直接出力
setup_small_camera_end(Camera001)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:もしかするとその強い憧れが転じて狂気となって<br>バルバロイと同調してしまったのかもしれません
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520033")

-- ▼直接出力
setup_small_camera_start(Camera_EX2)
-- ▲直接出力

	--★★ラヴェイン★★:大切なものを失い、己の記憶も徐々に蝕まれ
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520034")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラヴェイン★★:いつしか自分こそ継承者であると信じ込むことで<br>失った多くを埋めようとしていたのかもしれない
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520035")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520036")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0021")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:今となっては、もう知る由もないことですが
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_009_0520037")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
Appear(Actor003)
Appear(Actor004)
Appear(Actor005)
setup_small_camera_end(Camera_EX2)
setup_small_camera_start()
wait_time(0.2)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{0.413, 0, 4.733}, 3.8)
wait_time(0.2)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,{-0.718, 0, 4.89}, 4.0)
wait_time(0.4)
PlayActionDirect(Actor005,"to Wlk")
slidemove(Actor005,{-0.109, 0, 4.189}, 4.0)
wait_time(1.8)
setup_small_camera_start(Camera003)
wait_time(1.6)
turn_lookat(Actor003,Actor001,0.4)
wait_time(0.3)
turn_lookat(Actor004,Actor001,0.4)
turn_lookat(Actor005,Actor001,0.4)
wait_time(0.2)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.1)
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(0.1)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.6)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor004,0.4)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor004,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0004")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:そろそろ開演だってさ、早く席に行こうぜ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_009_0520039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520040")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Sad")

	--★★ラグネル★★:ねえ、ディナタンちゃん大丈夫なの？<br>だって、まだ――
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_009_0520041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_009_0520042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:…そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520043")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{1.23, 0, 4.733},1.0)
wait_time(1.0)
PlayActionDirect(Actor003,"to Std_Loop")
setup_small_camera_end()
setup_small_camera_start(Camera_EX)
-- ▲直接出力

	--★★ガウェイン★★:そんなことより、ノワール<br>上手くやれよ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_009_0520045")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_009_0520046")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520047")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera_EX)
setup_small_camera_start()
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,0.5,0.4)
wait_time(0.4)
slidemove(Actor003,{1.21498, 0, 7.19}, 1.2)
wait_time(1.2)
turn_chara(Actor003,180,0.5)
wait_time(0.5)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ガウェイン★★:それじゃ、俺たちは行こうぜ<br>あとはおふたりごゆっくり
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_009_0520048")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor003)
Hide(Actor004)
Hide(Actor002)
turn_lookat(Actor001,Actor005,0)
turn_lookat(Actor005,Actor001,0)
set_common_look_at(Actor001,Actor005)
set_common_look_at(Actor005,Actor001)
fadein(FADE_TIME)
wait_time(1.4)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520050")


	--★★ギネヴィア★★:………
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_009_0520051")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_009_0520053","EA_009_0520054")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:…お手をどうぞ、お姫様
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520057")

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0028")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ギネヴィア★★:へ？なにそれ
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_009_0520058")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え、エスコートだろ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520059")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Laugh")

	--★★ギネヴィア★★:ずっと黙ってたと思ったらいきなりそれ？<br>似合わないことしないでよ～！
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_009_0520060")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0021")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そ、そんなに似合わないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520061")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0011")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ギネヴィア★★:ぜーんぜん、似合わない
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_009_0520062")

	change_face(Actor005,"Laugh")

	--★★ギネヴィア★★:いいのよ、ノワールはいつも通りで
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_009_0520063")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ひ、ひさしぶり
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520066")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★ギネヴィア★★:そんなに久しぶりでもないけど
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_009_0520067")

	change_face(Actor001,"Sad")

	--★★ノワール★★:そうかな？そうかもな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520068")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:でも…なんか、すごく久しぶりな気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520069")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0010")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ギネヴィア★★:…そうね。なんだかんだいって<br>ずっと一緒にいたもんね
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_009_0520070")

	goto Block1end

::Block1end::
	change_face(Actor001,"Laugh")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520072")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ギネヴィア★★:………
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_009_0520073")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…ギネヴィア、あの…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520074")

	change_face(Actor005,"Normal")

	--★★ギネヴィア★★:
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_009_0520075")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520076")

	PlayAction(Actor005,"to  Std_Sad01")
	change_face(Actor005,"Shy")

	--★★ギネヴィア★★:…コンサート、一緒に見ても、いい？
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_009_0520077")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:…もちろん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520078")


	--★★女子生徒A★★:入場する生徒は、こちらの冊子を<br>忘れず受け取ってくださーい
	Talk(Actor006,"NPCNAME_0146","speech","L","EA_009_0520079")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
wait_time(0.4)
ShowImageItem("104000290")
wait_time(0.6)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ほら、ギネヴィアの分
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0520081")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
HideImageItem()
wait_time(0.6)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0048")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ギネヴィア★★:…ありがと
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_009_0520082")

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
load_image_preload("104000290", "content_still_10400029_image", "104000290_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110091)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor011")
	InitializeCharacter_3D_Preload("401022","001","401022001","content_animationpack__common","FacialPack","Actor012")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor013")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
