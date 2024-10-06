-- このluaスクリプトは、PT5_01_0026.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
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
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:現在、学園には５つのクラスがある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260002")


	--★★ランスロット★★:それぞれのクラスは専攻が違っていて
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:入学のさい、その者の資質に合わせて<br>配属されるクラスが決まるかたちになっている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260004")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:たとえばこのクラス<br>『<ruby=ヴァンデル・ピーク>遥か望む剣</ruby>』は…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260005")


	--★★ランスロット★★:戦闘技術に優れた者が集められ<br>技術向上を目的としたカリキュラムが組まれる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260006")


	--★★ランスロット★★:他には情報戦に特化した『<ruby=ケッテ・クロイツ>連鎖する幸運</ruby>』<br>国防を目的とした『<ruby=レゾナンツ・カーロ>響き合う正義</ruby>』
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260007")


	--★★ランスロット★★:支援や戦場における衛生などを学ぶ<br>『<ruby=エーヴィヒ・ヘルツ>永遠を謳う愛</ruby>』などといったクラスがある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT5_01_00260009","PT5_01_00260010","PT5_01_00260011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:配属されたあと<br>クラスを移ることはできないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00260012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:あまり例が多いわけではないが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260013")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:入学後、個人の希望や成績で<br>クラスが変わった生徒もいるな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:戦闘技術の向上か…<br>今でも十分に自信はあるつもりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00260015")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:それは過去の<br>傭兵としての経験からくるものだろう？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260016")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:これからお前たちが戦うのはバルバロイだ<br>過去の経験だけではどうにもならない場面も多い
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:驕ることなく<br>新たな知識を吸収していけ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260018")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたはさっき<br>５つのクラスがあると言っていたが
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00260019")

	change_face(Actor001,"Normal")

	--★★ノワール★★:『遥か望む剣』、『連鎖する幸運』、<br>『響き合う正義』それに『永遠を謳う愛』
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00260020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:４つしかなくないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00260021")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:もうひとつのクラス<br>『<ruby=ラウネン・ジョーカー>気まぐれな道化師</ruby>』は少々特殊でな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260022")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:特定の教室をもたず<br>カリキュラムも決められていないんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260023")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そ、それがクラスって言えるのか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00260024")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:彼らともいずれ会うことになるだろう<br>そのときまで楽しみにしておけ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260025")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:なにはともあれ各クラスは<br><dot>基本的には</dot>同じ顔触れで３年勉強することになる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:仲良くやっていってくれ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0034")
-- ▲直接出力

	--★★ランスロット★★:…さてと。では、みんな、外に出てくれ<br>授業を始める
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:今から実習をするのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00260029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0007")
-- ▲直接出力

	--★★ランスロット★★:ああ。今日は実戦形式で行う<br>気を抜けば怪我では済まない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260030")


	--★★ランスロット★★:気合を入れていけよ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00260031")

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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
