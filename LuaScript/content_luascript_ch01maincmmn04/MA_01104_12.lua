-- このluaスクリプトは、MA_01104_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",104,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_006)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:箔をつけたいのよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:あなたも同じでしょ？ヨソ者で、大事にされてなくて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120003")


	--★★ノワール★★:…ヨソ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_120004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:わたしもともとね、キャメリアードの産まれなの今から行くとこね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120005")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:キャメリアードって…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_120006")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:カレドニアが攻め落とした国おかげで今はバルバロイの巣窟
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120007")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:わたしはそのキャメリアードの－－元王女さま
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120008")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあ、キミは──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_120009")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:あなたはわたしが買い上げた傭兵全力でわたしを守り抜きなさい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:最初から、そのつもりで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_120011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★ギネヴィア★★:か弱いわたしには飾りが必要なの王妃っていうレッテルじゃあなくてね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120012")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:そもそも、どうしてログレスの王妃に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_120014")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…教えたげない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120015")

	change_face(Actor003,"Sad")

	--★★ギネマウア★★:…
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_120016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:キャメリアードからログレスに逃げて来た愛しき国民たちに帰る場所を！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120017")

	PlayAction(Actor002,"to  Std_Surp")

	--★★ギネヴィア★★:キャメリアードに取り残された愛しき国民たちに救いの手を！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120018")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:どうこのカリスマ！これぞ燃えるシチュエーション！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")

	--★★ギネマウア★★:…殿下、制圧されたキャメリアードに生存者は－－
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_120020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:いるわ！ぜったい！！カレドニアの捕虜になったり、してるよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120021")


	--★★ギネマウア★★:………左様ですね。殿下
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_120022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01104_120023","MA_01104_120024")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:王妃がすることじゃないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_120026")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:あなたまでそんなこと言わないでよ…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:無茶はしょーち！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120028")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:燃えるな戦う王妃殿下
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_120030")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:でしょおっ？高貴な生まれに似合わぬたくましき胆力と行動力！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120031")

	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:せっかくのレッテルだもんね利用してやんないと
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120032")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to  Std_No")

	--★★ギネマウア★★:…おいたわしい
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_120034")


	--★★ギネマウア★★:自分の意のままに出来そうな者を拾いただイキがるのみとは…
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_120035")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:う、うっ、うるっさいわねえ…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120036")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネマウア★★:いくらご友人がいないからとは言え買収なされるなど…
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_120037")

	open_cutin(1,2)
	on_cutin(1,Actor002,"Surprise")

	--★★ギネヴィア★★:うっ、ふっ、ぐっ、ううっ、うるしゃい…！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01104_120039")

	close_cutin()
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:ノワール様に見返りは？
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_120040")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:もちろん、報酬は弾むわよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120041")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:また…異国のコイン？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_120043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネマウア★★:…おいたわしい
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_120044")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:こっちがローマのコインでね！見てよ！こっちがね、フランスのコイン！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120045")

	PlayAction(Actor003,"to  Std_No")

	--★★ギネマウア★★:各所でお拾いになった物をコレクションとは…お金としては価値のない異国の…
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_120046")

	open_select_window_tag(Actor001,"Normal","MA_01104_120047","MA_01104_120048")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ありがとう大事なコレクションをくれたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_120050")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:このあいだ渡されたときは正直意味がわからなかったけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_120051")

	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:…誰かにあげることなんてないんだからね？だいじにしてよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120052")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:ガラクタばっかり…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_120054")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:ちょっと！ねえ！やめてよ！もう怒った！もう見せない！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120055")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:いいもんね！こーゆーのは理解されないままこっそり集めるのが楽しいんだもんね！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120056")

	goto Block2end

::Block2end::
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ま。発想が貧困よね。我ながらこんなにジャラジャラお金持ちなのに
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120058")


	--★★ギネヴィア★★:異国情緒に夢見がちなワケ外の世界に旅立ちたいワケ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120059")


	--★★ギネヴィア★★:その旅の終わりで帰って来られる場所が要る
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120060")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:だからわたしはあなたに期待してるわけ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120061")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:旅路と帰路を拓く派手な飾りになって欲しいなって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_120062")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
