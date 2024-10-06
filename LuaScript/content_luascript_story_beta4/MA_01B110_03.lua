-- このluaスクリプトは、MA_01B110_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",60,CharaPos116102_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName116102_01,CameraPos116102_01_003)
	Camera002 = SetTemplate("Actor002",-120,CharaPos116102_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_511_01_StdController","to Std_Loop",CameraAssetBundleName116102_01,CameraPos116102_01_001)
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
set_enable_auto_lookat_all(false)
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
	load_area_scene(116102)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101067","001","101067001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor003,"telop","narration","N","MA_01B110_031001")


	--★★テロップ★★:
	Talk(Actor003,"telop","narration","N","MA_01B110_031002")


	--★★テロップ★★:
	Talk(Actor003,"telop","narration","N","MA_01B110_031003")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:
	Talk(Actor003,"telop","narration","N","MA_01B110_031004")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
wait_time(2.8)
hide_image(2.8)
wait_time(4.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ニニアン", "否定")
-- ▲直接出力

	--★★ニニアン★★:奇跡とは呼べない
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01B110_030002")

	change_face(Actor002,"Sad")

	--★★ニニアン★★:聖杯は、あまねく願いを叶えるものにあらず<br>それは人間の都合の良い解釈に過ぎない
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01B110_030003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（え──…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B110_030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ニニアン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ニニアン★★:穢れが満ちる地に産まれし武器<br>万象の力が宿る器──それこそが聖杯
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01B110_030006")


	--★★ニニアン★★:ゆえに観測者に選定されし者だけが<br>この地の浄化を義務づけられる
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01B110_030008")


	--★★ノワール★★:（なにを、言ってるんだ…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B110_030009")


	--★★ニニアン★★:杯に溢れる武器たる力…それを<br>歴史に穢れが満ちしときにこの地へ注げば──
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01B110_030010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ニニアン★★:歴史は<br>終わりの続きを往くことができる
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01B110_030011")


	--★★ノワール★★:（…つまり聖杯を、しかるべきときに使えば<br>バルバロイによる終末を回避できる…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B110_030012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ニニアン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ニニアン★★:しかし地の穢れ…浮き上がり切ってはいない<br>終わりはまだ遠い、まだ早い
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01B110_030013")


	--★★ニニアン★★:聖杯もまた、この廃都に封じられたまま<br>歴史上に現れるのもまだ先のこと
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01B110_030014")

	change_face(Actor002,"Normal")

	--★★ニニアン★★:ゆえに、ときが来たる前に<br>聖杯の力を──
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01B110_030015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Talk")
 --PlayPartVoice("ニニアン", "肯定")
-- ▲直接出力

	--★★ニニアン★★:この地ではなく<br>ただひとりへと注ぎましょう
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01B110_030016")


	--★★ノワール★★:（…！？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B110_030018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★ニニアン★★:これは因果を捻じ曲げる行為
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01B110_030019")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ニニアン★★:武器たる因子を膨大に注がれたその者は恐らく<br>この歴史における特異点となるでしょう
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01B110_030020")


	--★★ニニアン★★:未来の観測者により<br>見出されるであろう歴戦の勇士──
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01B110_030021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ニニアン★★:すなわち<br>──継承者となる
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01B110_030022")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
--ニニアン,CHRNAME_NINIAN @名前変更
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_No")
 --PlayPartVoice("ニニアン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ニニアン★★:これは妖精ニニアンの咎<br>雪げぬ罪を贖う宿命、継承者に刻むのみ
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B110_030024")


	--★★ニニアン★★:その騎士道の歩みの末に<br>奇跡などありえない
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B110_030026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★ニニアン★★:それでも貴方は──
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B110_030027")

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
	load_area_scene_preload(116102)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101067","001","101067001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName116102_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
