-- このluaスクリプトは、EA_007_034.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_05","110071_05_h")
Include("content_adv_advsmall_110071_05","Template110071_05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_05_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_005)
	Camera002 = SetTemplate("Actor002",130,CharaPos110071_05_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_05_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_001)
	Camera005 = SetTemplate("Actor005",-10,CharaPos110071_05_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110071_05_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_007)
	InitializeTemplateRandomCamera110071_05()
	InitializeTemplate110071_05()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
INIT_CHRPOS(Actor006,{-16.27,0.128,5.7,0},false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115074)
	Actor001 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0019")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★モルドレッド★★:拷問のし甲斐がねえヤツらだったぜ<br>簡単にクチ割りやがった
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0340004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0032")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラグネル★★:相変わらず容赦ない拷問だったね～…
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0340005")

-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0014")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★モルドレッド★★:拷問で手加減しても意味ねえだろ<br>んなことより──
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0340006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★モルドレッド★★:あのログレス兵もどきの雇い主が割れた<br>ローマ軍の残党だ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0340007")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to  Std_Surp")
PlayActionDirect(Actor003,"to  Std_Surp")
PlayActionDirect(Actor004,"to  Std_Surp")
PlayActionDirect(Actor005,"to  Std_Surp")
wait_time(1.5)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:…ルーシャスと関係が？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0340009")

-- ▼直接出力
change_face(Actor003,"Normal")
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
PlayActionDirect(Actor005,"to Std_Loop")
PlayPartVoiceDirect("モルドレッド","0007")
-- ▲直接出力

	--★★モルドレッド★★:なくはねえらしいが、最近分派した奴らだ<br>今は独自に行動してるみてえだな
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0340010")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0025")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ガウェイン★★:あいつらが着てたログレス兵の服は…<br>ロンディニウムの事件ンときに使われたヤツか…
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_007_0340012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0013")
-- ▲直接出力

	--★★モルドレッド★★:
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0340014")


	--★★モルドレッド★★:あのガキを放っておいたら<br>面倒なことになったかもしれねえ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0340015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0046")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラグネル★★:ローマ軍残党が金と力を手にしちゃってたかも<br>ってことね…危なかった～
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0340016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0038")
-- ▲直接出力

	--★★モルドレッド★★:クラリスの手柄だ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0340017")

	PlayAction(Actor005,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0040")
-- ▲直接出力

	--★★クラリス★★:…褒めてもなんにも出ませんよお
	Talk(Actor005,"CHRNAME_CLARICE","speech","L","EA_007_0340018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★モルドレッド★★:事実だ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0340019")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0009")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★クラリス★★:さっきだって偶然モルくんが<br>通りがかってくれたから良かったけど…
	Talk(Actor005,"CHRNAME_CLARICE","speech","L","EA_007_0340020")

	PlayAction(Actor002,"to Finger")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0038")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラグネル★★:偶然にしては出来過ぎじゃない？それ
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0340021")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★モルドレッド★★:んだよ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0340022")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0007")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガウェイン★★:たまたまあんなとこにいるかあ？
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_007_0340023")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoiceDirect("モルドレッド","0014")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★モルドレッド★★:んだよ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0340024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","EA_007_0340026","EA_007_0340027")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ノワール★★:奇跡が起きたんだよ、きっと
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0340030")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0038")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★モルドレッド★★:そーだよ、奇跡的にあんなとこにいたんだよ<br>オレは
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0340031")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガウェイン★★:いやいやいや
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_007_0340032")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ラグネル★★:いやいやいや
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0340033")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
set_enable_auto_lookat_all(true)
PlayPartVoiceDirect("モルドレッド","0017")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★モルドレッド★★:黙れ、口閉じろ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0340034")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:ずっと見守ってくれていたんじゃないのか？<br>もしかして
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0340037")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0032")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★モルドレッド★★:気色悪ィこと言うんじゃねえよ<br>そんな暇じゃねえし
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0340038")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ガウェイン★★:『<ruby=おまえのクラス>気まぐれな道化師</ruby>』の生徒に命令して<br>見張らせたりしてたんじゃねえのー？
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_007_0340039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラグネル★★:誰を見守ってたのかなあ
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0340041")

	goto Block1end

::Block1end::
-- ▼直接出力
set_enable_auto_lookat_all(true)
CloseTalkWindow()
IN_WALK(Actor006,CharaPos110071_05_007)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
turn_lookat( Actor005,Actor004, 0.3)
wait_time(0.3)
PlayActionDirect(Actor005,"to Std_Loop")
PlayPartVoiceDirect("マルイル","0008")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★マルイル★★:
	Talk(Actor006,"CHRNAME_MARIL","speech","L","EA_007_0340044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0041")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★モルドレッド★★:勝手にまとめんなマッシュルームカット
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0340045")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0007")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★マルイル★★:ノワールさんたちや<br>モルドレッドさんが動いてくれたのも──
	Talk(Actor006,"CHRNAME_MARIL","speech","L","EA_007_0340046")


	--★★マルイル★★:カイルくんが助かったのも<br>ログレスの危機が回避できたのも──
	Talk(Actor006,"CHRNAME_MARIL","speech","L","EA_007_0340047")

	PlayAction(Actor006,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0010")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★マルイル★★:クラリスさんの選択のおかげ<br>ということですね！
	Talk(Actor006,"CHRNAME_MARIL","speech","L","EA_007_0340048")

-- ▼直接出力
PlayPartVoiceDirect("クラリス","0028")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★クラリス★★:…！<br>そんな
	Talk(Actor005,"CHRNAME_CLARICE","speech","L","EA_007_0340049")

	PlayAction(Actor005,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0048")
-- ▲直接出力
	change_face(Actor005,"Shy")

	--★★クラリス★★:運が良かった、だけです
	Talk(Actor005,"CHRNAME_CLARICE","speech","L","EA_007_0340051")

	change_face(Actor003,"Normal")

	--★★ノワール★★:そうかな
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0340052")

-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0038")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★クラリス★★:そうですよ
	Talk(Actor005,"CHRNAME_CLARICE","speech","L","EA_007_0340053")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0024")
-- ▲直接出力

	--★★カイル★★:
	Talk(Actor007,"NPCNAME_0386","speech","N","EA_007_0340055")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(0.5 + FADE_TIME)
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
wait_time(FADE_TIME)
fadein(0)
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★クラリス★★:（驚いたことに）
	Talk(Actor005,"CHRNAME_CLARICE","mind","N","EA_007_0340058")

-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0023")
-- ▲直接出力

	--★★カイル★★:白い花…<br>ぐちゃぐちゃになっちゃった
	Talk(Actor007,"NPCNAME_0386","speech","N","EA_007_0340060")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★クラリス★★:（不幸はまだ、視えていた）
	Talk(Actor005,"CHRNAME_CLARICE","mind","N","EA_007_0340061")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115074)
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
