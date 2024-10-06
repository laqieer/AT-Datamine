-- このluaスクリプトは、CO_101037_0202_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_007)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:ここのお店、たまにですけど<br>絞りたての野菜ジュースを出してるんですよ
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:へえ、健康に良さそうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02020008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:その隣のお店は串焼きのハムがおいしいし<br>さらにその隣は…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020009")

	open_select_window_tag(Actor001,"Normal","CO_101037_02020011","CO_101037_02020012","CO_101037_02020013")
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
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺もオススメの店があってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02020015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:反対側の通りにある露店なんだけど<br>そこのドライフルーツがすごく美味い
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02020016")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:そうなんですか、知りませんでした！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020017")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あとで見に行ってみようか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02020018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:はい！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラシア★★:あっちのボンボンのお店もいいし<br>あとは、えーっと…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020021")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…食べ物の店が多くないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02020022")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラシア★★:えっ！？<br>…私、食いしん坊に思われちゃいますかね…？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:少し、そう思った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02020024")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ラシア", "否定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:そんなことないですよ？時間ができたときに<br>おいしいものを探して食べ歩いているだけです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020025")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:それを一般的に<br>食いしん坊って言うような気がするな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02020026")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ここの露店に詳しいんだな<br>よく来てるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02020028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:そうですね<br>友達と学園の帰りによく来ます
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:食べ物のメニューが充実していて<br>何度来ても飽きないんですよ
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020031")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
set_common_look_at(Actor002,Actor003)
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:あっ！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020033")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Appear(Actor003)
Appear(Actor004)
lookat_delay_weight_reset(Actor002,1.1)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("フレン", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フレン★★:ふたりも買い物～？
	Talk(Actor003,"CHRNAME_FREN","speech","L","CO_101037_02020035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:うん<br>ノワールの買い物に付き合ってるの
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020036")


	--★★ラシア★★:フレンとローラも買い物？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▲直接出力
-- ▼直接出力
play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor003,"Smile")
	on_cutin(2,Actor004,"Smile")
	change_face(Actor005,"Smile")

	--★★フレン／ローラ★★:うん
	Talk(Actor005,"CHRNAME_FREN_LOLA","speech","N","CO_101037_02020039")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "照れ")
-- ▲直接出力
	close_cutin()

	--★★フレン★★:ここのアクセサリー屋さん<br>今日が新作の入荷日なんだよ
	Talk(Actor003,"CHRNAME_FREN","speech","L","CO_101037_02020040")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "肯定2")
-- ▲直接出力

	--★★ラシア★★:いいのあった？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020041")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ローラ", "肯定")
-- ▲直接出力

	--★★ローラ★★:お姉ちゃんとお揃いのブローチを買ったの
	Talk(Actor004,"CHRNAME_LOLA","speech","L","CO_101037_02020042")

-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:このあいだもお揃いで<br>なにか買ってなかった？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Surprise")

	--★★フレン★★:あれはバレッタだから別物！
	Talk(Actor003,"CHRNAME_FREN","speech","L","CO_101037_02020044")

-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力

	--★★ローラ★★:お揃いはいくつあっても嬉しいよね
	Talk(Actor004,"CHRNAME_LOLA","speech","L","CO_101037_02020045")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フレン★★:私たちはそろそろ行くね
	Talk(Actor003,"CHRNAME_FREN","speech","L","CO_101037_02020047")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera004)
end
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ローラ", "喜び")
-- ▲直接出力

	--★★ローラ★★:ふたりも<br>いいものが見つかるといいね
	Talk(Actor004,"CHRNAME_LOLA","speech","L","CO_101037_02020048")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor004)
Hide(Actor003)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:仲がいいんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02020050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:双子ですもんね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020051")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いや、ラシアとふたりがさ<br>俺と話しているときと全然違ったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02020052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ラシア★★:私たち、幼馴染なんですよ<br>ふたりの前だと自然と素が出ちゃうというか
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020053")

	change_face(Actor001,"Normal")

	--★★ノワール★★:素って…<br>あのとき俺たちの教室に入ってきたような？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02020054")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ラシア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラシア★★:もっ、もう！恥ずかしいから忘れてください<br>あのときのことは…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020055")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ、ごめんごめん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02020056")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:ふふっ、<br>では私たちもお目当ての店に行きましょう
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02020057")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ラシア_ランクアップ2_4")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
