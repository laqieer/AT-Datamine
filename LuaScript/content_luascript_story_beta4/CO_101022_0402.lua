-- このluaスクリプトは、CO_101022_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_01","110141_01_h")
Include("content_adv_advsmall_110141_01","Template110141_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_008)
	InitializeTemplateRandomCamera110141_01()
	InitializeTemplate110141_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor002,"J_Head")
lookat_weight(Actor004,0.4,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ちょっといいか、イゾルデ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04020002")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:妙な組み合わせね、お前たち<br>私になんの用かしら
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101022_04020003")


	--★★ノワール★★:薬を貰いに来たんだ<br>必要なのは…えーっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:打ち身に効くやつ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04020006")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:だ、そうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04020007")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
-- ▲直接出力

	--★★イゾルデ★★:別に構わないけれど…<br>随分な態度ね、モルドレッド？
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101022_04020008")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★イゾルデ★★:頼みごとをする人間のそれとは思えないわ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101022_04020009")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:いちいち小言言ってくんなチビオンナ<br>それより早く薬を寄越せ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04020010")


	--★★モルドレッド★★:オレの留守中にあのバカがもっとヘマして<br>怪我を増やしてたら目も当てられねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:クラリスのための薬なのね<br>…まあ、そんなことだろうとは思ったけど
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101022_04020012")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力

	--★★マルディサント★★:おいおい、自分のキラーズを<br>バカとか言うか？普通
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","CO_101022_04020014")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力

	--★★ノワール★★:（マルディサントも<br>近いことを言っていた気がするけど…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101022_04020015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★マルディサント★★:もうちょっと言いかたあるだろ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","CO_101022_04020016")


	--★★マルディサント★★:あいつだって頑張ってんだから――
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","CO_101022_04020017")

-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "激怒")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Anger")

	--★★モルドレッド★★:オレとあいつのことに<br>外野が口出ししてくんじゃねぇ
	Talk(Actor002,"CHRNAME_MORDRED","speech","N","CO_101022_04020019")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★マルディサント★★:…あんだぁ！？
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","CO_101022_04020020")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
wait_time(0.2)
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
PlayActionDirect(Actor002,"to Wlk")
wait_time(2.0)
PlayActionDirect(Actor002,"to Std_Loop")
Hide(Actor002)
se_play("SE_ADV_MA_01B109_11_Door")
wait_time(1.5)
Hide(Actor002)
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor004,"J_Head")
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:モルドレッドの<br>物言いが許せなかったのはわかるけれど
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101022_04020022")


	--★★イゾルデ★★:確かに余計な口出しは<br>するべきではなかったかもしれないわね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101022_04020023")

	PlayAction(Actor004,"to  Std_Sad01")
	change_face(Actor004,"Shy")

	--★★マルディサント★★:う、うるせえ！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","CO_101022_04020025")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:はい、薬。お前が届けておいてくれる？<br>依頼主はマルディサントが怒らせてしまったから
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101022_04020027")

	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("マルディサント", "照れ")
-- ▲直接出力

	--★★マルディサント★★:だ、だから、悪かったって言ってんだろ！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","CO_101022_04020028")


	--★★ノワール★★:（言ってなかった気がするけどな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101022_04020029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:あのふたりのことは<br>当人同士に任せておくのが一番よ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101022_04020030")

	change_face(Actor004,"Normal")

	--★★マルディサント★★:へいへい…
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","CO_101022_04020031")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:でも…なんで突然怒り出したんだ、あいつ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04020032")

	open_select_window_tag(Actor001,"Normal","CO_101022_04020034","CO_101022_04020035")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:マルディサントの態度が悪すぎたから？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04020037")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("マルディサント", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★マルディサント★★:マジかよ、アンタまで言うのか！？
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","CO_101022_04020038")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だって本当に悪かったからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04020039")

	PlayAction(Actor004,"to  Std_Angry")
	change_face(Actor004,"Anger")

	--★★マルディサント★★:ほっとけ！<br>そーゆー性質なんだよ、アタシは！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","CO_101022_04020040")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:「頑張ってる」って言葉がいけなかったのかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04020042")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:気になるのなら、聞いてみたら？
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101022_04020043")

	change_face(Actor003,"Normal")

	--★★イゾルデ★★:答えてもらえるかは知らないけれど
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101022_04020044")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まぁともかく、薬を届けに行くよ<br>あまり待たせるわけにもいかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04020046")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:それが賢明ね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101022_04020047")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_モルドレッド_ランクアップ4_3")
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
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
