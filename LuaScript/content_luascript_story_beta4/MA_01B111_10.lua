-- このluaスクリプトは、MA_01B111_10.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_TextOnly()
	template1()

end

function Play()
	StartPlay()


	--★★ニニアン★★:穢れが満ちる地に産まれし武器<br>万象の力が宿る器──それこそが聖杯
	Talk(Actor002,"CHRNAME_NINIAN","speech","N","MA_01B111_100003")


	--★★ニニアン★★:ゆえに観測者に選定されし者だけが<br>この地の浄化を義務づけられる
	Talk(Actor002,"CHRNAME_NINIAN","speech","N","MA_01B111_100004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:（聖杯は、みんなが思うような<br>願い事を叶える代物ではない…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B111_100005")


	--★★ニニアン★★:杯に溢れる武器たる力…それを<br>歴史に穢れが満ちし時にこの地へ注げば──
	Talk(Actor002,"CHRNAME_NINIAN","speech","N","MA_01B111_100006")


	--★★ニニアン★★:歴史は<br>終わりの続きを往くことができる
	Talk(Actor002,"CHRNAME_NINIAN","speech","N","MA_01B111_100007")


	--★★ニニアン★★:しかし地の穢れ…浮き上がり切ってはいない<br>終わりはまだ遠い、まだ早い
	Talk(Actor002,"CHRNAME_NINIAN","speech","N","MA_01B111_100008")


	--★★ニニアン★★:ゆえに、ときが来たる前に<br>聖杯の力を──
	Talk(Actor002,"CHRNAME_NINIAN","speech","N","MA_01B111_100010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ニニアン★★:この地ではなく<br>ただひとりへと注ぎましょう
	Talk(Actor002,"CHRNAME_NINIAN","speech","N","MA_01B111_100011")


	--★★ノワール★★:（そして俺は──…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B111_100012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ニニアン★★:これは因果を捻じ曲げる行為<br>その者は必ずや歴史における特異点となる
	Talk(Actor002,"CHRNAME_NINIAN","speech","N","MA_01B111_100013")


	--★★ニニアン★★:すなわち<br>──継承者となる
	Talk(Actor002,"CHRNAME_NINIAN","speech","N","MA_01B111_100014")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（誰かに、聖杯によって<br>継承者にさせられた…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B111_100015")


	--★★ニニアン★★:これは妖精ニニアンの咎<br>雪げぬ罪を贖う宿命、継承者に刻むのみ
	Talk(Actor002,"CHRNAME_NINIAN","speech","N","MA_01B111_100017")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（どちらにせよ継承者が聖杯を手にすれば<br>「終わりの続きを往く」ことができる…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B111_100019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:（そう言っているはずなのに）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B111_100020")


	--★★ニニアン★★:その騎士道の歩みの末に<br>奇跡などありえない
	Talk(Actor002,"CHRNAME_NINIAN","speech","N","MA_01B111_100021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:（奇跡が、ありえない？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B111_100022")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
