-- このluaスクリプトは、CO_101064_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_02","112041_02_h")
Include("content_adv_advsmall_112041_02","Template112041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112041_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112041_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos112041_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_005)
	InitializeTemplateRandomCamera112041_02()
	InitializeTemplate112041_02()
-- ▼直接出力
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor006, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★市民（中年男）②★★:お、来た来た<br>ヤツらのアジトを特定できたんだ
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_10020002")


	--★★市民（中年男）★★:これからすぐ出発すんぜ？<br>準備はできてっか
	Talk(Actor005,"NPCNAME_0251","speech","N","CO_101064_10020003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リアム★★:心配無用です
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★市民（男）★★:…正直な話<br>オレが一番気に入らねぇのはよ
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_10020007")


	--★★市民（男）★★:オレたちが留守にしてるのをいいことに<br>ダサ坊どもが
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_10020009")


	--★★市民（男）★★:黒牙団の名を騙って<br>弱ぇ連中を虐めて粋がってることだ
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_10020010")


	--★★市民（男）★★:黒牙団がケンカを売るのは<br>強ぇヤツだ！国だ！権力だ！
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_10020012")


	--★★市民（男）★★:それを思い知らせてやろうぜ
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_10020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★リアム★★:気合十分といったところですね<br>それで、馬の準備はできているんですか？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10020014")


	--★★市民（中年男）②★★:３頭しか捕まえられなくてよ<br>おめえとノワッちゃんでふたり乗り…
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_10020016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リアム★★:いえ、先頭は私が。ノワールさんとキース<br>ロッシーとヨッシーがそれぞれ１頭としましょう
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10020018")


	--★★市民（中年男）★★:勝手なところは相変わらずだなぁ<br>こいつと付き合うの大変だろ、ノワっちゃん
	Talk(Actor005,"NPCNAME_0251","speech","N","CO_101064_10020019")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははは…<br>（ノワっちゃんって俺か…？）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_10020021")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★市民（男）★★:よっしゃ、行くぜ野郎ども！<br>パーティの始まりだーーーっ！！
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_10020022")

	PlayAction(Actor003,"to Sit01_Loop")
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Sad")
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
force_eyesync(Actor002,"Close")
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力

	--★★リアム★★:先生…<br>今一度、黒き牙を剥くことをお許しください…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10020024")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リアム_ランクアップ10_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
