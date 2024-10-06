-- このluaスクリプトは、CO_101022_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",100,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera002 = SetTemplate("Actor002",250,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:よお、継承者ちょっとツラ貸せ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010002")

	open_select_window_tag(Actor001,"Normal","CO_101022_01010004","CO_101022_01010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いいけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010007")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:えらく素直だなケッ、つまんねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010009")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ただ返事しただけなのになんで文句言われるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:いやだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010012")

-- ▼直接出力
PlayPartVoice("モルドレッド", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:へえいい度胸してんじゃねえか
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:だが残念だったなおめえの却下を却下だ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010014")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:だったら俺の意見なんて聞かなくてよかっただろ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010015")

	goto Block1end

::Block1end::
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:で、なんの用なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:まどろっこしいのは嫌えだ単刀直入に言うぜ。手を貸せ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★モルドレッド★★:『気まぐれな道化師』は知ってんな？このオレが級長を務める、キャメ学の特殊部隊だ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:噂くらいは聞いてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010022")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:一応クラスと扱われてはいるけど決められた教室を持たず、授業もほとんど受けず
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010023")


	--★★ノワール★★:この島で起きたトラブルの解決を一手に引き受けてるんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010024")


	--★★ノワール★★:それがどうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:どこもかしこもゴタゴタしてるせいで来る任務は増える一方だ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010027")


	--★★モルドレッド★★:ただ学園崩壊の余波でうちも人員を失っちまった
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:このままじゃ手が回らねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010030")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:だから…正義のミカタな継承者サマにご助力を願おうと思ってな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010031")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:別に、俺は正義の味方ってわけじゃないしそもそも別のクラスに在籍してるし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010033")

-- ▼直接出力
PlayPartVoice("モルドレッド", "納得")
-- ▲直接出力

	--★★モルドレッド★★:ほう？じゃあ俺らが出動できず狂暴なバルバロイが町の人間を襲っても
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010035")


	--★★モルドレッド★★:継承者サマは知らぬ顔を決めこむってわけだ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:ああっ、なんて酷い！血も涙もないとはこのことです！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010038")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:そうは言ってないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:わかった。俺も手伝うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010041")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:別にあんたのためじゃないけど困ってる人を無視するわけにはいかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:そうそうわかりゃいいんだよ、わかりゃ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010044")


	--★★ノワール★★:で？俺はなにをすればいいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010045")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:まだなにも決めてねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010047")

	PlayAction(Actor002,"to  Std_Talk")

	--★★モルドレッド★★:さっき言ったろ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:今日はコトの重要性を<br>わかりゃいいんだよ、わかりゃ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010049")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…はぁ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:んじゃーそのうち、うちの連中がたまり場にしてる場所に連れてってやる
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010051")

-- ▼直接出力
PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力

	--★★モルドレッド★★:準備して待ってろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_01010052")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:はいはい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010053")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
PlayActionDirect(Actor002,"to Wlk")
wait_time(2.0)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(CHARA_IN_WAIT)
Hide(Actor002)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん、安請け合いしちゃったかな？大丈夫だろうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_01010055")

-- ▼直接出力
local trustParam = set_communication_acquired("モルドレッド_コミュランク", "モルドレッド_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
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
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
