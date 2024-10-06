-- このluaスクリプトは、MA_01B900_02.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera002 = SetTemplate("Actor002",169.2735,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115110)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:往生際が悪いな。我ながら
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020002")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor001,Camera001,EntryData110101_01_06,CameraAssetBundleName110101_01,CameraPos110101_01_106)
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0,321.0251,0,0.1)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:『<ruby=けが>穢</ruby>れし血』の話を聞いた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_020004")


	--★★ノワール★★:「<ruby=あんた>穢れた血</ruby>は近く<br>バルバロイの王と化す」と
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:俺がアーサー・<dot>ペンドラゴン</dot>の名を背負うのは<br>どうしてだと思う？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020008")

	open_select_window_tag(Actor001,"Normal","MA_01B900_020009","MA_01B900_020010","MA_01B900_020011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:『ペンドラゴン』は家名じゃないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_020013")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★アーサー★★:ならカッコ良くて良かったがな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020014")

	change_face(Actor002,"Normal")

	--★★アーサー★★:ギネヴィア・ペンドラゴンとか<br>物々しくて良さそうだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020015")

	change_face(Actor002,"Normal")

	--★★アーサー★★:…いいや、彼女は断るかな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:カッコ付けだと思ってたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_020018")

	change_face(Actor002,"Smile")

	--★★アーサー★★:それもある
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020019")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、それもあるのか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_020020")

	change_face(Actor002,"Smile")

	--★★アーサー★★:ハッタリきかせてみたいものだろう？<br>男の子なら
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★アーサー★★:お前と同じだよ、ノワール
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020022")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:父親からなにかを引き継いでいるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_020024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★アーサー★★:…ああ。そうだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020025")

	change_face(Actor002,"Normal")

	--★★アーサー★★:もとは父の二つ名なんだ<br>異名と言ってもいい
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020026")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★アーサー★★:我が父<br>ユーサー・ペンドラゴン
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020028")


	--★★アーサー★★:彼から罪を<br>継承していることを忘れないためだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…罪
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_020032")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:昔話になる
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020033")


	--★★アーサー★★:ユーサーは我が母イグレーヌと出会う随分前に<br>妖精を見つけた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020034")


	--★★アーサー★★:まだバルバロイが現れ始めた頃…<br>その対処に追われ、各地を転々としていた頃だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020035")


	--★★アーサー★★:その妖精の名を『ニニアン』という
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:！？<br>妖精、ニニアン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_020037")


	--★★アーサー★★:ユーサーがバルバロイの脅威から<br>ニニアンを護るうち、ふたりは恋に落ちた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:人ならざる者との恋
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020039")


	--★★アーサー★★:バルバロイという災禍に立ち向かうべく<br>異種族間で手を取り合う…理想的な形にも思えた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020040")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★アーサー★★:だが人と妖精の交わりは禁忌だった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020041")

	change_face(Actor001,"Normal")

	--★★ノワール★★:禁じられていた…？<br>しきたりかなにかが原因で？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_020042")

	PlayAction(Actor002,"to  Std_No")

	--★★アーサー★★:いいや<br>妖精とはそもそも不可侵な存在
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:万象の力を宿す聖杯に導く観測者たるべき者<br>極めて聖なる種であるべき存在
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020044")

	change_face(Actor002,"Sad")

	--★★アーサー★★:ゆえに人間と交わると均衡が崩れ<br>交わった人間側に穢れが降り注ぐのだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_020045")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115110)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
