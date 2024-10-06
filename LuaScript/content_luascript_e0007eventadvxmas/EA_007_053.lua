-- このluaスクリプトは、EA_007_053.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",350,CharaPos110151_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_007)
	Camera002 = SetTemplate("Actor002",0,CharaPos110151_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_003)
	Camera003 = SetTemplate("Actor003",-120,CharaPos110151_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_006)
	Camera004 = SetTemplate("Actor004",51.5,CharaPos110151_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_005)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
set_pos(Actor001,{2.18,0,-1.77})
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{-1.39,0,-1.25})
--set_pos(Actor002,{0.053,0,0.002})
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor004,"J_Head")
lookat_weight(Actor003,0.5,0.1,0.85,0.2)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor004,Actor003,"J_Head")
lookat_weight(Actor004,0.5,0.1,0.85,0.2)
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102012)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({3.79, 2.656, 3.453,   22.6, 278.678, 0,   25})
-- ▲直接出力
-- ▼直接出力
CameraEx_02 = set_camera({-0.27, 0.76, 1.21,   15, 205, 0,   25})
-- ▲直接出力
-- ▼直接出力
CameraEx_03 = set_camera({4.72, 3.14, 5.02,   25, 241.4, 0,   26})
-- ▲直接出力
-- ▼直接出力
CameraKyle = set_camera({-0.412, 2.09, 2.052,   27.4, 15.1, 0,   25})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_Running_FI")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115153)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101023","003","101023003","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(CameraKyle)
slidemove(CameraKyle,-0.47,2.09,2.052,8)
PlayPartVoiceDirect("子供_男1","0002")
-- ▲直接出力

	--★★カイル★★:叔父さん、どうしてそんなに急ぐの？
	Talk(Actor003,"NPCNAME_0386","speech","N","EA_007_0530003")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera004)
PlayPartVoiceDirect("市民中年_男2","0008")
-- ▲直接出力

	--★★カイルの叔父★★:早くパパやママに会いたいだろう？
	Talk(Actor004,"NPCNAME_0389","speech","N","EA_007_0530004")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
CameraKyle = set_camera({-0.412, 2.09, 2.052,   27.4, 15.1, 0,   25})
setup_small_camera_start(CameraKyle)
slidemove(CameraKyle,-0.47,2.09,2.052,8)
PlayPartVoiceDirect("子供_男1","0019")
-- ▲直接出力

	--★★カイル★★:でも、もう少し<br>降誕祭を楽しもうよ
	Talk(Actor003,"NPCNAME_0386","speech","N","EA_007_0530005")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★カイルの叔父★★:いいから<br>早くログレスを出るんだ
	Talk(Actor004,"NPCNAME_0389","speech","N","EA_007_0530006")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★カイル★★:だめだよ、まだクラリスお姉ちゃんたちに<br>お別れも言ってないもん
	Talk(Actor003,"NPCNAME_0386","speech","N","EA_007_0530007")

	PlayAction(Actor004,"to  Std_Angry")

	--★★カイルの叔父★★:言うことを聞け
	Talk(Actor004,"NPCNAME_0389","speech","N","EA_007_0530008")

-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0028")
-- ▲直接出力

	--★★カイル★★:叔父さん…？
	Talk(Actor003,"NPCNAME_0386","speech","N","EA_007_0530009")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力

	--★★カイルの叔父★★:幸せそうな顔をしおって
	Talk(Actor004,"NPCNAME_0389","speech","N","EA_007_0530010")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("市民中年_男2","0010")
-- ▲直接出力

	--★★カイルの叔父★★:あの両親のあいだに産まれたのが<br>運の尽きだったな
	Talk(Actor004,"NPCNAME_0389","speech","N","EA_007_0530011")

-- ▼直接出力
setup_small_camera_start(CameraEx_01)
slidemove(CameraEx_01,{4.035,2.759,3.416},10)
-- ▲直接出力

	--★★カイル★★:………どういう、こと…？
	Talk(Actor003,"NPCNAME_0386","speech","N","EA_007_0530012")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力

	--★★クラリス★★:ツキがありませんでしたね<br><ruby=あなた>叔父様</ruby>こそ
	Talk(Actor002,"CHRNAME_NAMELES","speech","N","EA_007_0530014")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,150,0.25)
wait_time(0.15)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,195,0.25)
wait_time(0.1)
PlayActionDirect(Actor004,"to Std_Loop")
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",0.4)
wait_time(0.15)
PlayActionDirect(Actor003,"to Std_Loop")
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★カイルの叔父★★:だ、誰だッ！？
	Talk(Actor004,"NPCNAME_0389","speech","N","EA_007_0530017")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor002)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat_position(Actor002,CharaPos110151_01_003[1],CharaPos110151_01_003[2],CharaPos110151_01_003[3],0)
slidemove(Actor002,{CharaPos110151_01_003[1],CharaPos110151_01_003[2],CharaPos110151_01_003[3]},2.8)
wait_time(0.4)
setup_small_camera_start(CameraEx_02)
slidemove(CameraEx_02,{0.989,1.54,3.972},2.5)
turn(CameraEx_02,10,205,0,2.5)
wait_time(2.4)
turn_chara(Actor002,340,0.35)
wait_time(0.35)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
--クラリス,CHRNAME_CLARICE @名前変更
lookat_weight_reset(Actor003)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_Running_FI")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力

	--★★クラリス★★:キャンドルサービスです
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","EA_007_0530022")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力

	--★★カイル★★:クラリスお姉ちゃん！！
	Talk(Actor003,"NPCNAME_0386","speech","N","EA_007_0530023")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Run")
turn_lookat_position(Actor003,{0.719,0,1.665},0.1)
wait_time(0.1)
slidemove(Actor003,{0.719,0,1.665},1.1)
wait_time(1.1)
keep_delay_ik_lookat(Actor004,Actor003,"J_Head",0.7)
turn_chara(Actor003,340,0.25)
wait_time(0.25)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.8)
set_enable_auto_lookat(Actor004, true)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★カイルの叔父★★:ま、待てカイル！！
	Talk(Actor004,"NPCNAME_0389","speech","N","EA_007_0530025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0015")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クラリス★★:カイルくんを誘拐し、ご両親を脅し<br>一族の商売を独占しようとしていたのですね
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","EA_007_0530027")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★カイルの叔父★★:なんのことだかわからんな<br>甥を返してもらおうか
	Talk(Actor004,"NPCNAME_0389","speech","N","EA_007_0530028")

	change_face(Actor002,"Normal")

	--★★クラリス★★:そうして掌握した販路を利用し<br>裏ではローマ軍残党と繋がることで──
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","EA_007_0530029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★クラリス★★:ローマ軍残党は<br>兵糧と武器を得ることができる
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","EA_007_0530030")

-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クラリス★★:彼らは、魔女との戦いに疲弊したログレスを<br>叩くべく暗躍していた
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","EA_007_0530031")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クラリス★★:そしてあなたは、死の商人として<br>さらに成り上がろうとした
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","EA_007_0530032")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("市民中年_男2","0030")
-- ▲直接出力

	--★★カイルの叔父★★:き、貴様、どこでそれを…！？
	Talk(Actor004,"NPCNAME_0389","speech","N","EA_007_0530033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0011")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クラリス★★:神は見ておられますよ？
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","EA_007_0530034")


	--★★カイルの叔父★★:な…！？
	Talk(Actor004,"NPCNAME_0389","speech","N","EA_007_0530035")

-- ▼直接出力
setup_small_camera_start(CameraEx_03)
slidemove(CameraEx_03,{4.82,3.2,5.08},10)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★クラリス★★:冗談です<br>そんな思惑、視えはしませんでしたが──
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","EA_007_0530036")

-- ▼直接出力
PlayPartVoiceDirect("クラリス","0010")
-- ▲直接出力

	--★★クラリス★★:
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","EA_007_0530037")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor001)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{CharaPos110151_01_007[1],CharaPos110151_01_007[2],CharaPos110151_01_007[3]},2.2)
wait_time(2.0)
setup_small_camera_start(Camera001)
wait_time(0.2)
turn_chara(Actor001,335,0.1)
wait_time(0.1)
PlayActionDirect(Actor001,"to Std_Loop")
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:ローマからの亡命者が教えてくれたよ<br>残党と繋がった商人がいることを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_007_0530039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")

	--★★カイルの叔父★★:
	Talk(Actor004,"NPCNAME_0389","speech","N","EA_007_0530041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クラリス★★:外にお出かけをし、隙を作ってみましたが<br>襲ってこなかったことを鑑みるに…
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","EA_007_0530042")


	--★★クラリス★★:誘拐を企てている者はカイルくんの所在を<br>正確には把握していないことがわかりました
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","EA_007_0530043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力

	--★★ノワール★★:あとは疑わしい叔父が<br>カイルを迎えに来るのを待って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_007_0530044")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★クラリス★★:罪を自白させれば、このとおり
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","EA_007_0530045")

-- ▼直接出力
setup_small_camera_start()
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力

	--★★ノワール★★:どこから作戦が漏れるかわからなかったから<br>俺とクラリスのふたりで実行するしかなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_007_0530046")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0023")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クラリス★★:一歩間違えれば<br>ログレスにも多大な被害が及ぶ事態でしたが──
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","EA_007_0530047")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_007_0530048")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1.0)
-- ▲直接出力

	--★★カイル★★:
	Talk(Actor003,"NPCNAME_0386","speech","N","EA_007_0530049")


	--★★カイルの叔父★★:…それで、勝ったつもりか？
	Talk(Actor004,"NPCNAME_0389","speech","N","EA_007_0530050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★クラリス★★:懺悔するおつもりは？
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","EA_007_0530051")

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
setup_prop_object_preload(10102012)
preload_sound("BGM_Battle_Running_FI")
	InitializeLoad_Preload()
	load_area_scene_preload(115153)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101023","003","101023003","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
