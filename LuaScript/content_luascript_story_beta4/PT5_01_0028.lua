-- このluaスクリプトは、PT5_01_0028.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "挨拶")
-- ▲直接出力

	--★★ケイ★★:では<br>ホームルームを始める
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00280002")


	--★★ケイ★★:近年のバルバロイによる被害の増加に伴い<br>様々な国でキラーズの力が注目されてきている
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00280003")


	--★★ケイ★★:実際問題として<br>キラーズを派遣してほしいという依頼が
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00280004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:他の国や都市から<br>連日のように私のもとに届いている
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00280005")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:また、ＧＳについての知識を<br>共有してほしいという相談も来ており
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00280006")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ケイ★★:今年は交換留学生というかたちで<br>ローマから皇太子を特別に迎え入れた
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00280007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT5_01_00280008","PT5_01_00280009","PT5_01_00280010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:わざわざ皇太子が勉強に来ているんだな<br>ちょっと驚きだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00280011")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ケイ★★:ルーシャス皇太子たっての依頼でな<br>自分の目でＧＳを見てみたいそうだ
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00280012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:交換留学生ってことは<br>こっちから誰かがローマに行っているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00280013")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ケイ★★:うむ<br>生徒会長とその妹が行っている
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00280014")

	change_face(Actor005,"Smile")

	--★★ケイ★★:妹は入学早々にＧＳを果たした優等生だ
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00280015")

	change_face(Actor005,"Smile")

	--★★ケイ★★:海の向こうの状況を調べつつ<br>ローマの文化を学んできてもらおうと思っている
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00280016")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:皇太子…ルーシャスだったか<br>いまいち苦手なんだよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00280017")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★ケイ★★:…貴公に<br>皇太子についての所感を尋ねたつもりはない
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00280018")

	change_face(Actor005,"Normal")

	--★★ケイ★★:今回は<br>聞かなかったことにしておく
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00280019")

	goto Block1end

::Block1end::
	change_face(Actor005,"Normal")

	--★★ケイ★★:学園で学ぶにあたり<br>ログレス以外の人々と交流する機会もあろう
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00280020")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:くれぐれもログレスの評判を下げるようなことは<br>せんでくれたまえよ
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00280021")

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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
