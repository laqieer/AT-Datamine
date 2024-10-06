-- このluaスクリプトは、MA_01A110_11.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_005)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
change_face(Actor002,"Sad")
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("エレイン", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:ＧＳが、憎らしくて
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_110002")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:憎い…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_110003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:一番上の兄が<br>バルバロイに憑かれました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_110004")


	--★★エレイン★★:喰われ切り、消化されてしまえば<br>私たちは彼の存在自体を忘れてしまう
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_110005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ああ、あのロンディニウムの孤児たちが<br>親の顔を忘れてしまっているように…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_110006")

-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:だから私はお兄ちゃんとＧＳを果たし<br>バルバロイに消化される前に──
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_110007")


	--★★エレイン★★:…家族を記憶に留めることに<br>しました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_110009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★エレイン★★:恨みを晴らしたい、許せはしないと思いました<br>そんな私たちにＧＳは戦う力をくれました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_110011")

-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:けど戦えば、削れていく<br>武器となってくれた人が傷ついていく
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_110012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エレイン★★:家族を覚えておくためのＧＳだったはずなのに<br>お兄ちゃんの、運命は…もう変わらない
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_110014")


	--★★エレイン★★:バルバロイに喰われて消えるか<br>擦り切れて聖遺物化してしまうか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_110016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:…そうだね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_110017")

-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:戦おうにも兄に傷つくのを強いる<br>戦わなければ多くが傷つく
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_110018")


	--★★エレイン★★:戦いが終わっても何も遺らない<br>かえってきても、かえってこない
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_110019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:ＧＳを済ませ、戦いに足を踏み入れて<br>今更何をと思われるかもしれません、けど──
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_110020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:もう、踏み出せなくて<br>ずっと、甘ったれで
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_110021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力

	--★★エレイン★★:気づけば、言葉も出なくて
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_110022")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
