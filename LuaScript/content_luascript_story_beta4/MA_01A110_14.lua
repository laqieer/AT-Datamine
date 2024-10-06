-- このluaスクリプトは、MA_01A110_14.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111042_01","111042_01_h")
Include("content_adv_advsmall_111042_01","Template111042_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111042_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111042_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111042_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_003)
	InitializeTemplateRandomCamera111042_01()
	InitializeTemplate111042_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002, 1.0, 0, 0.3, 0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111042)
	Actor001 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラシア★★:もっとも醜い理由で<br>ここまで来てしまいました
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A110_140002")


	--★★ラシア★★:3人とも決めた理由はそれぞれなのです<br>だけど私は──
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A110_140003")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "否定")
-- ▲直接出力

	--★★ヴェルナルス★★:戦いの理由に美醜はない
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A110_140004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor001, 1.0, 0.1, 0.3, 0.5)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.5)
-- ▲直接出力

	--★★ヴェルナルス★★:だが、ユーサーの件が真実だったとして<br>ルーシャス様に傾倒する理由がお前にあるか？
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A110_140005")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ラシア", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラシア★★:私は<br>ルーシャス様に傾いたのではありません
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A110_140006")

	change_face(Actor001,"Sad")

	--★★ラシア★★:口実が見つかった、だけなのです
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A110_140008")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラシア★★:…ヴェルナルス様はどうして<br>ルーシャス様に付いているのですか？
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A110_140010")

-- ▼直接出力
message_nowait("MA_01A110_140011")
wait_time(0.5)
stop_nowait_message_voice_and_lipsync()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:あの御方はローマの民のことを<br>第一に考えておられる
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A110_140013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ヴェルナルス★★:しかしあの方が征くのは<br>アーサー王やノワールのような英雄の道ではない
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A110_140014")

-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ヴェルナルス★★:最後には世界から憎まれ<br>罵られることになるだろう
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A110_140015")

-- ▼直接出力
 --PlayPartVoice("ラシア", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラシア★★:そんな…だというのに？
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A110_140016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ヴェルナルス★★:だが、一度決めた居場所を変えられるほど<br>俺は老い先が長いわけではない
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A110_140017")


	--★★ヴェルナルス★★:あの御方の最期…<br><ruby=ローマ>俺が仕え続けて来た国</ruby>の行く末…
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A110_140018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:それを確かめねば<br>己の生涯を否定してしまう気がしてならない
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A110_140020")


	--★★ヴェルナルス★★:たとえ、醜き死に様を晒そうとも
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A110_140021")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:………ヴェルナ叔父様
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A110_140022")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor003,Camera003,EntryData111042_01_03,CameraAssetBundleName111042_01,CameraPos111042_01_103)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ローラ", "挨拶")
-- ▲直接出力

	--★★ローラ★★:ヴェルナルス様<br>よろしいでしょうか
	Talk(Actor003,"CHRNAME_LOLA","speech","L","MA_01A110_140024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor001 , 0.6)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:ああ
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A110_140025")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-115,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラシア", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラシア★★:ローラ
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A110_140027")

-- ▼直接出力
lookat_delay_weight(Actor003, {0.7, 0.08, 0.6, 0.5} , 0.5)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.5)
 --PlayPartVoice("ローラ", "肯定")
-- ▲直接出力

	--★★ローラ★★:なに？ラシア
	Talk(Actor003,"CHRNAME_LOLA","speech","L","MA_01A110_140028")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラシア★★:…無理、しないで
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A110_140029")

-- ▼直接出力
 --PlayPartVoice("ローラ", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:あはは
	Talk(Actor003,"CHRNAME_LOLA","speech","L","MA_01A110_140030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ローラ", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ローラ★★:お姉ちゃんが待ってるからね
	Talk(Actor003,"CHRNAME_LOLA","speech","L","MA_01A110_140031")


	--★★ローラ★★:私が全部──お姉ちゃんより先に全部<br>試してもらわなきゃダメなの
	Talk(Actor003,"CHRNAME_LOLA","speech","L","MA_01A110_140032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラシア★★:た、試す…って、なに…？
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A110_140033")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ローラ", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ローラ★★:だから、無理くらいしなきゃ
	Talk(Actor003,"CHRNAME_LOLA","speech","L","MA_01A110_140035")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111042)
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111042_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
